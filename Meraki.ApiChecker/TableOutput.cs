using Meraki.ApiChecker.Extensions;
using Meraki.ApiChecker.Models;
using Microsoft.OpenApi.Models;
using Spectre.Console;
using System.Reflection;
using System.Runtime.Serialization;

namespace Meraki.ApiChecker;

public static class TableOutput
{
	public static void DisplayRemainingTags(OpenApiDocument apiSchema)
		=> DisplayAndPruneTag(apiSchema, null, null);

	public static void DisplayAndPruneTag(
		OpenApiDocument apiSchema,
		Dictionary<string, List<MethodDetails>>? implementedEndpoints,
		string? tagRestriction)
	{
		var implementedTable = new Table()
			.AddColumns("Method", "Endpoint", "OperationId", "Tags", "Implementation", "NewMethodName", "DeficientDataModels", "Schema")
			.BorderStyle("green");
		var duplicateTable = new Table()
			.AddColumns("Method", "Endpoint", "OperationId", "Tags", "Implementation")
			.BorderStyle("orange1");
		var missingTable = new Table()
			.AddColumns("Method", "Endpoint", "OperationId", "Tags")
			.BorderStyle("red");
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
					switch (existingImplementations.Count)
					{
						case 1:
							var singleImplementation = existingImplementations[0];

							var schemaDetails = string.Empty;
							if (pathOperation.Value.Responses.Count > 0)
							{
								var response = pathOperation.Value.Responses.First();
								var responseValue = response.Value;
								var responseSchema = responseValue.Content.First().Value.Schema;
								if (responseSchema is not null)
								{
									var responseProperties = responseSchema.Properties;
									if (responseProperties.Count == 0)
									{
										schemaDetails = $"{responseSchema.Type}";
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
							_ = implementedTable.AddRow(
								pathOperation.Key.ToString(),
								pathKpv.Key,
								pathOperation.Value.OperationId,
								string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)),
								methodName,
								expectedMethodName != methodName ? expectedMethodName : string.Empty,
								string.Join(", ", singleImplementation.DeficientDataModels),
								schemaDetails
								);
							_ = (implementedEndpoints?[pathKpv.Key].Remove(singleImplementation));
							break;
						default:
							foreach (var duplicateImplementation in existingImplementations)
							{
								_ = duplicateTable.AddRow(
									pathOperation.Key.ToString(),
									pathKpv.Key,
									pathOperation.Value.OperationId,
									string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)),
									duplicateImplementation.Method.Name ?? string.Empty,
									string.Join(", ", existingImplementations[0].DeficientDataModels)
									);
								_ = (implementedEndpoints?[pathKpv.Key].Remove(duplicateImplementation));
							}

							break;
					}
				}
				else
				{
					_ = missingTable.AddRow(
						pathOperation.Key.ToString(),
						pathKpv.Key,
						pathOperation.Value.OperationId,
						string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)));
				}

				_ = pathKpv.Value.Operations.Remove(pathOperation);
			}
		}

		if (implementedTable.Rows.Count > 0)
		{
			_ = implementedTable.Title(
				tagRestriction is not null
					? $"'{tagRestriction}' implemented endpoints ({implementedTable.Rows.Count})"
					: "Remaining implemented endpoints",
				new Style(Color.Green));
			AnsiConsole.Write(implementedTable);
		}

		if (duplicateTable.Rows.Count > 0)
		{
			_ = duplicateTable.Title(
				tagRestriction is not null
					? $"'{tagRestriction}' duplicate endpoints ({duplicateTable.Rows.Count})"
					: "Remaining implemented endpoints",
				new Style(Color.Orange1));
			AnsiConsole.Write(duplicateTable);
		}

		if (missingTable.Rows.Count > 0)
		{
			_ = missingTable.Title(
				tagRestriction is not null
					? $"'{tagRestriction}' missing endpoints ({missingTable.Rows.Count})"
					: "Remaining missing endpoints",
				new Style(Color.Red));
			AnsiConsole.Write(missingTable);
		}
	}

	private static string CheckSchemaProperties(OpenApiSchema responseSchema, Type responseModel, string responseSchemaPath = "")
	{
		var result = string.Empty;
		var modelProperties = responseModel?
			.GetProperties()
			.Where(p => p.CanWrite)
			.ToDictionary(
				p =>
				{
					var dataMember = p.GetCustomAttribute<DataMemberAttribute>();
					return dataMember is not null
						? dataMember.Name!
						: throw new InvalidDataException("Expected property to have a DataMember with a name set");
				},
				p => p
			) ?? new();

		foreach ((var schemaPropertyName, var schemaProperty) in responseSchema.Properties)
		{
			// Do we have a matching property?
			if (modelProperties.TryGetValue(schemaPropertyName, out var modelProperty))
			{
				// Yes - Do we have sub properties?
				if (schemaProperty.Properties.Count > 0)
				{
					// Yes - check those too
					result += CheckSchemaProperties(
						schemaProperty,
						modelProperty.PropertyType,
						responseSchemaPath + (responseSchemaPath != string.Empty ? "." : string.Empty) + schemaPropertyName
					);
				}
			}
			else
			{
				// No - we have a schema property that's not on the model
				if (result != string.Empty)
				{
					result += "\n";
				}
				result += $"Missing schema property '{responseSchemaPath}{(responseSchemaPath != string.Empty ? "." : string.Empty)}{schemaPropertyName}' ({schemaProperty.Type})";
			}
		}

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

	internal static void DisplayRemainingInterfaces(Dictionary<string, List<MethodDetails>> implementedEndpoints)
	{
		// We don't need to print the table if there is nothing to write into it
		if (implementedEndpoints.All(i => implementedEndpoints[i.Key].Count == 0))
		{
			return;
		}

		var extraTable = new Table()
			.Title("Implementations without Endpoints", new Style(Color.Red))
			.AddColumns("Method", "Endpoint", "Namespace", "Name")
			.BorderStyle("red");
		foreach (var implementation in implementedEndpoints)
		{
			foreach (var method in implementation.Value)
			{
				_ = extraTable.AddRow(
					method.RefitAttribute.Method.ToString(),
					method.RefitAttribute.Path,
					method.Method.DeclaringType?.FullName ?? string.Empty,
					method.Method.Name
					);
			}
		}

		AnsiConsole.Write(extraTable);
	}
}
