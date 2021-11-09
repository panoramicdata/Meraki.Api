using Meraki.ApiChecker.Extensions;
using Meraki.ApiChecker.Models;
using Microsoft.OpenApi.Models;
using Spectre.Console;

namespace Meraki.ApiChecker
{
	public static class TableOutput
	{
		public static void DisplayRemainingTags(
			OpenApiDocument apiSchema)
		{
			DisplayAndPruneTag(apiSchema, null, null);
		}

		public static void DisplayAndPruneTag(
			OpenApiDocument apiSchema,
			Dictionary<string, List<MethodDetails>>? implementedEndpoints,
			string? tagRestriction)
		{
			var implementedTable = new Table()
				.AddColumns("Method", "Endpoint", "OperationId", "Tags", "Implementation")
				.BorderStyle("green");
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
					List<MethodDetails>? implementation = null;
					implementedEndpoints?.TryGetValue(pathKpv.Key, out implementation);
					var existingImplementation = implementation?.SingleOrDefault(e => e.RefitAttribute.Method == refitMethod);

					if (existingImplementation != null)
					{
						implementedTable.AddRow(
							pathOperation.Key.ToString(),
							pathKpv.Key,
							pathOperation.Value.OperationId,
							string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)),
							existingImplementation?.Method.Name ?? string.Empty);
						implementedEndpoints?[pathKpv.Key].Remove(existingImplementation!);
					}
					else
					{
						missingTable.AddRow(
							pathOperation.Key.ToString(),
							pathKpv.Key,
							pathOperation.Value.OperationId,
							string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)));
					}

					pathKpv.Value.Operations.Remove(pathOperation);
				}
			}
			if (implementedTable.Rows.Count > 0)
			{
				implementedTable.Title(
					tagRestriction is not null
						? $"'{tagRestriction}' implemented endpoints ({implementedTable.Rows.Count})"
						: "Remaining implemented endpoints",
					new Style(Color.Green));
				AnsiConsole.Write(implementedTable);
			}

			if (missingTable.Rows.Count > 0)
			{
				missingTable.Title(
					tagRestriction is not null
						? $"'{tagRestriction}' missing endpoints ({missingTable.Rows.Count})"
						: "Remaining missing endpoints",
					new Style(Color.Red));
				AnsiConsole.Write(missingTable);
			}
		}

		internal static void DisplayRemainingInterfaces(Dictionary<string, List<MethodDetails>> implementedEndpoints)
		{
			var extraTable = new Table()
				.Title("Implementations without Endpoints", new Style(Color.Red))
				.AddColumns("Method", "Endpoint", "Namespace", "Name")
				.BorderStyle("red");
			foreach (var implementation in implementedEndpoints)
			{
				foreach (var method in implementation.Value)
				{
					extraTable.AddRow(
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
}
