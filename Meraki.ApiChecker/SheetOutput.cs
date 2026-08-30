using Meraki.ApiChecker.Data;
using Meraki.ApiChecker.Extensions;
using Meraki.ApiChecker.Models;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Runtime.Serialization;

namespace Meraki.ApiChecker;

public static class SheetOutput
{
	public static EndpointSet CreateWorksheet(
		OpenApiDocument apiSchema,
		Dictionary<string, List<MethodDetails>>? implementedEndpoints,
		string? tagRestriction)
	{
		var endpointSet = new EndpointSet();

		foreach (var pathKpv in apiSchema.Paths)
		{
			var operations = tagRestriction == null
				? pathKpv.Value.Operations
				: pathKpv.Value.Operations.Where(o => o.Value.Tags.Any(t => t.Name == tagRestriction));

			foreach (var pathOperation in operations)
			{
				AddOperation(endpointSet, implementedEndpoints, pathKpv.Key, pathOperation);
				_ = pathKpv.Value.Operations.Remove(pathOperation);
			}
		}

		return endpointSet;
	}

	/// <summary>
	/// Files one path operation under implemented, duplicated or missing.
	/// </summary>
	private static void AddOperation(
		EndpointSet endpointSet,
		Dictionary<string, List<MethodDetails>>? implementedEndpoints,
		string path,
		KeyValuePair<OperationType, OpenApiOperation> pathOperation)
	{
		// Look for a matching operation
		var refitMethod = pathOperation.Key.ToHttpMethod();
		List<MethodDetails>? pathImplementations = null;
		_ = (implementedEndpoints?.TryGetValue(path, out pathImplementations));
		var existingImplementations = pathImplementations?
			.Where(e => e.RefitAttribute.Method == refitMethod)
			.ToList();

		var tags = string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name));

		if (existingImplementations is null || existingImplementations.Count == 0)
		{
			endpointSet.MissingEndpoints.Add(new()
			{
				Method = pathOperation.Key.ToString(),
				Endpoint = path,
				OperationId = pathOperation.Value.OperationId,
				Tags = tags,
			});
			return;
		}

		if (existingImplementations.Count > 1)
		{
			foreach (var duplicateImplementation in existingImplementations)
			{
				endpointSet.DuplicatedEndpoints.Add(new()
				{
					Method = pathOperation.Key.ToString(),
					Endpoint = path,
					OperationId = pathOperation.Value.OperationId,
					Tags = tags,
					Implementation = duplicateImplementation.Method.Name ?? string.Empty,
				});
				_ = (implementedEndpoints?[path].Remove(duplicateImplementation));
			}

			return;
		}

		var singleImplementation = existingImplementations[0];
		var methodName = singleImplementation.Method.Name ?? string.Empty;
		var expectedMethodName = pathOperation.Value.OperationId.FirstCharToUpper() + "Async";

		endpointSet.ImplementedEndpoints.Add(new()
		{
			Method = pathOperation.Key.ToString(),
			Endpoint = path,
			OperationId = pathOperation.Value.OperationId,
			Tags = tags,
			Implementation = methodName,
			NewMethodName = expectedMethodName != methodName ? expectedMethodName : string.Empty,
			DeficientDataModels = string.Join(", ", singleImplementation.DeficientDataModels),
			Schema = DescribeResponseSchema(pathOperation.Value, singleImplementation)
		});
		_ = (implementedEndpoints?[path].Remove(singleImplementation));
	}

	/// <summary>
	/// Describes how the implementation's response type compares to the schema the operation declares.
	/// </summary>
	private static string DescribeResponseSchema(OpenApiOperation operation, MethodDetails implementation)
	{
		if (operation.Responses.Count == 0)
		{
			return string.Empty;
		}

		var response = operation.Responses.First();
		var responseValue = response.Value;

		// If there is a content then there should be a schema; otherwise it's probably something like a 204
		var responseSchema = responseValue.Content.Count == 0 ? null : responseValue.Content.First().Value.Schema;
		if (responseSchema is null)
		{
			// If the response is a 204 then we're not expecting a schema
			return response.Key == "204"
				? "-"
				: "NULL Schema";
		}

		if (responseSchema.Properties.Count == 0)
		{
			return DescribeSchemaWithoutProperties(responseSchema, implementation);
		}

		// For anything we can write to, there should be a DataMember attribute
		var schemaDetails = $"{responseSchema.Type} ({responseSchema.Properties.Count})";

		// Compare the responseProperties to those on the response object defined
		// Find the properties that match (and check their type)
		var schemaPropertyDetails = CheckSchemaProperties(
			responseSchema,
			implementation.ResponseType);

		return schemaPropertyDetails == string.Empty
			? schemaDetails
			: $"{schemaDetails} {schemaPropertyDetails}";
	}

	/// <summary>
	/// With no properties to compare, the only check available is whether one side is an array and
	/// the other is not.
	/// </summary>
	private static string DescribeSchemaWithoutProperties(OpenApiSchema responseSchema, MethodDetails implementation)
		=> responseSchema.Type == "array" && !implementation.ResponseType!.IsGenericList()
			// The base types don't match
			? $"{responseSchema.Type} - Response schema is '{responseSchema.Type}', model type '{implementation.ResponseType?.Name}' is not IEnumerable"
			: $"{responseSchema.Type}";

	/// <summary>
	/// Compare the properties of the schema to the properties of the response object.
	/// </summary>
	/// <param name="apiSchema">The API schema</param>
	/// <param name="modelType">The model Type</param>
	/// <param name="responseSchemaPath">The path within the API schema</param>
	/// <returns>A string with any additional or missing properties</returns>
	/// <exception cref="InvalidDataException"></exception>
	private static string CheckSchemaProperties(OpenApiSchema apiSchema, Type? modelType, string responseSchemaPath = "")
	{
		// Check for writable properties without DataMember attribute set
		var modelPropertiesWithoutDataMembers = modelType?
			.GetProperties()
			.Where(modelProperty => modelProperty.CanWrite && modelProperty.GetCustomAttribute<DataMemberAttribute>() is null)
			.ToList();
		if (modelPropertiesWithoutDataMembers?.Count > 0)
		{
			// Don't do anything else
			return $" Found writable properties without DataMember: {string.Join(", ", modelPropertiesWithoutDataMembers.Select(p => p.Name))}";
		}

		var modelProperties = GetPropertiesByDataMemberName(modelType);

		// Loop through the properties in the schema and check if they exist in the responseModel
		// Deconstruct each Dictionary entry Key and Value into two variables
		var result = string.Empty;
		foreach ((var schemaPropertyName, var schemaProperty) in apiSchema.Properties)
		{
			// Can we find a modelProperty matching on the schema property name
			if (modelProperties.TryGetValue(schemaPropertyName, out var modelProperty))
			{
				// YES - Do we have sub properties? If so, check those too.
				// TODO - See if the modelProperty has any sub properties as this might be different from the schema
				if (schemaProperty.Properties.Count > 0)
				{
					result += CheckSchemaProperties(
						schemaProperty,
						modelProperty.PropertyType,
						Join(responseSchemaPath, schemaPropertyName)
					);
				}

				continue;
			}

			// NO - we have a schema property that's not on the model
			if (result != string.Empty)
			{
				result += "\n";
			}

			result += $"Missing schema property '{Join(responseSchemaPath, schemaPropertyName)}' ({schemaProperty.Type})";
		}

		// TODO - report on any extra model properties that are not on the schema. The abandoned
		// attempt at this is in git history.
		return result;
	}

	/// <summary>
	/// Indexes the writable properties of the model by the name their DataMember attribute declares.
	/// </summary>
	private static Dictionary<string, PropertyInfo> GetPropertiesByDataMemberName(Type? modelType)
		=> modelType?
			.GetProperties()
			.Where(modelProperty => modelProperty.CanWrite)
			.ToDictionary(
				modelProperty => modelProperty.GetCustomAttribute<DataMemberAttribute>()?.Name
					?? throw new InvalidDataException($"Expected property {modelProperty.Name} to have DataMember attribute with a name set"),
				modelProperty => modelProperty
			) ?? [];

	private static string Join(string responseSchemaPath, string schemaPropertyName)
		=> responseSchemaPath == string.Empty
			? schemaPropertyName
			: $"{responseSchemaPath}.{schemaPropertyName}";

	internal static List<ImplementationWithoutEndpoint> GetRemainingInterfaces(Dictionary<string, List<MethodDetails>> implementedEndpoints)
	{
		var ImplementationsWithoutEndpoints = new List<ImplementationWithoutEndpoint>();

		foreach (var implementation in implementedEndpoints)
		{
			foreach (var method in implementation.Value)
			{
				ImplementationsWithoutEndpoints.Add(new()
				{
					Method = method.RefitAttribute.Method.ToString(),
					Endpoint = method.RefitAttribute.Path,
					Namespace = method.Method.DeclaringType?.FullName ?? string.Empty,
					Name = method.Method.Name
				});
			}
		}

		return ImplementationsWithoutEndpoints;
	}
}
