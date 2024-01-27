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
				// Look for a matching operation
				var refitMethod = pathOperation.Key.ToHttpMethod();
				List<MethodDetails>? pathImplementations = null;
				_ = (implementedEndpoints?.TryGetValue(pathKpv.Key, out pathImplementations));
				var existingImplementations = pathImplementations?.Where(e => e.RefitAttribute.Method == refitMethod).ToList();

				if (existingImplementations?.Count > 0)
				{
					if (existingImplementations.Count == 1)
					{
						var singleImplementation = existingImplementations[0];

						var schemaDetails = string.Empty;
						if (pathOperation.Value.Responses.Count > 0)
						{
							var response = pathOperation.Value.Responses.First();
							var responseValue = response.Value;
							// If there is a content then there should be a schema; otherwise it's probably something like a 204
							var responseSchema = responseValue.Content.Count == 0 ? null : responseValue.Content.First().Value.Schema;
							if (responseSchema is not null)
							{
								var responseProperties = responseSchema.Properties;
								if (responseProperties.Count == 0)
								{
									schemaDetails = $"{responseSchema.Type}";

									// No properties, is the base type roughly matching
									// At this point just check whether one is an array and the other isn't
									// Is the schema response an array and the model property is not IEnumerable
									if (responseSchema.Type == "array"
										&& !singleImplementation.ResponseType!.IsGenericList())
									{
										// YES - The base types don't match
										schemaDetails += $" - Response schema is '{responseSchema.Type}', model type '{singleImplementation.ResponseType?.Name}' is not IEnumerable";
									}
								}
								else
								{
									// For anything we can write to, there should be a DataMember attribute
									schemaDetails = $"{responseSchema.Type} ({responseProperties.Count})";
									// Compare the responseProperties to those on the response object defined
									// Find the properties that match (and check their type)
									// TODO

									var schemaPropertyDetails = CheckSchemaProperties(
										responseSchema,
										singleImplementation.ResponseType);

									if (schemaPropertyDetails != string.Empty)
									{
										schemaDetails += $" {schemaPropertyDetails}";
									}
								}
							}
							else
							{
								// If the response is a 204 then we're not expecting a schema
								schemaDetails = response.Key == "204"
									? "-"
									: "NULL Schema";
							}
						}

						var methodName = singleImplementation.Method.Name ?? string.Empty;
						var expectedMethodName = pathOperation.Value.OperationId.FirstCharToUpper() + "Async";

						endpointSet.ImplementedEndpoints.Add(new()
						{
							Method = pathOperation.Key.ToString(),
							Endpoint = pathKpv.Key,
							OperationId = pathOperation.Value.OperationId,
							Tags = string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)),
							Implementation = methodName,
							NewMethodName = expectedMethodName != methodName ? expectedMethodName : string.Empty,
							DeficientDataModels = string.Join(", ", singleImplementation.DeficientDataModels),
							Schema = schemaDetails
						});
						_ = (implementedEndpoints?[pathKpv.Key].Remove(singleImplementation));
					}
					else
					{
						foreach (var duplicateImplementation in existingImplementations)
						{
							endpointSet.DuplicatedEndpoints.Add(new()
							{
								Method = pathOperation.Key.ToString(),
								Endpoint = pathKpv.Key,
								OperationId = pathOperation.Value.OperationId,
								Tags = string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)),
								Implementation = duplicateImplementation.Method.Name ?? string.Empty,
							});
							_ = (implementedEndpoints?[pathKpv.Key].Remove(duplicateImplementation));
						}
					}
				}
				else
				{
					endpointSet.MissingEndpoints.Add(new()
					{
						Method = pathOperation.Key.ToString(),
						Endpoint = pathKpv.Key,
						OperationId = pathOperation.Value.OperationId,
						Tags = string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)),
					});
				}

				_ = pathKpv.Value.Operations.Remove(pathOperation);
			}
		}

		return endpointSet;
	}

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
		// Start out assuming we have nothing to report
		var result = string.Empty;

		// Check for writable properties without DataMember attribute set
		var modelPropertiesWithoutDataMembers = modelType?
			.GetProperties()
			.Where(modelProperty =>
			{
				var dataMemberAttribute = modelProperty.GetCustomAttribute<DataMemberAttribute>();
				return modelProperty.CanWrite && dataMemberAttribute is null;
			})
			.ToList();
		if (modelPropertiesWithoutDataMembers?.Count > 0)
		{
			result += $" Found writable properties without DataMember: {string.Join(", ", modelPropertiesWithoutDataMembers.Select(p => p.Name))}";
			// Don't do anything else
			return result;
		}

		// Get all the writable properties from the responseModel and put them in a Dictionary indexed by DataMember name
		var props = modelType?.GetProperties();
		var modelProperties = props?
			.Where(modelProperty => modelProperty.CanWrite)
			.ToDictionary(
				modelProperty =>
				{
					var dataMemberAttribute = modelProperty.GetCustomAttribute<DataMemberAttribute>();
					return dataMemberAttribute is not null
						? dataMemberAttribute.Name!
						: throw new InvalidDataException($"Expected property {modelProperty.Name} to have DataMember attribute with a name set");
				},
				modelProperty => modelProperty
			) ?? [];

		// Loop through the properties in the schema and check if they exist in the responseModel
		// Deconstruct each Dictionary entry Key and Value into two variables
		foreach ((var schemaPropertyName, var schemaProperty) in apiSchema.Properties)
		{
			// Can we find a modelProperty matching on the schema property name
			if (modelProperties.TryGetValue(schemaPropertyName, out var modelProperty))
			{
				// YES - Do we have sub properties?
				if (schemaProperty.Properties.Count > 0)
				{
					// YES - check those too
					result += CheckSchemaProperties(
						schemaProperty,
						modelProperty.PropertyType,
						responseSchemaPath + (responseSchemaPath != string.Empty ? "." : string.Empty) + schemaPropertyName
					);
				}

				// TODO - See if the modelProperty has any sub properties as this might be different from the schema
			}
			else
			{
				// NO - we have a schema property that's not on the model
				if (result != string.Empty)
				{
					result += "\n";
				}

				result += $"Missing schema property '{responseSchemaPath}{(responseSchemaPath != string.Empty ? "." : string.Empty)}{schemaPropertyName}' ({schemaProperty.Type})";
			}
		}

		// TODO - report on any extra model properties that are not on the schema
		//foreach (var property in responseModel.GetProperties().Where(p => p.CanWrite))
		//{
		//	var dataMember = property.GetCustomAttribute<DataMemberAttribute>();
		//	var dataMemberName = dataMember is not null
		//		? dataMember.Name!
		//		: throw new InvalidDataException("Expected property to have a DataMember with a name set");

		//	// Do we have a matching property?
		//	if (responseSchema.Properties.TryGetValue(dataMemberName, out var matchingSchemaProperty))
		//	{
		//		// Yes - Do we have sub properties?
		//		if (matchingSchemaProperty.Properties.Count > 0)
		//		{
		//			// Yes - check those too
		//			result += CheckSchemaProperties(
		//				matchingSchemaProperty,
		//				property.GetType(),
		//				responseSchemaPath + "." + dataMemberName
		//			);
		//		}
		//	}
		//	else
		//	{
		//		// No - we have an extra model property that's not on the schema
		//		result += "Extra model property";
		//	}
		//}
		return result;
	}

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
