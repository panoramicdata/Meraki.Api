using Meraki.ApiChecker.Extensions;
using Meraki.ApiChecker.Models;
using Microsoft.OpenApi.Models;
using Spectre.Console;

namespace Meraki.ApiChecker
{
	public static class TableOutput
	{
		public static void DisplayRemainingTags(
			OpenApiDocument apiSchema,
			Dictionary<string, List<MethodDetails>> implementedEndpoints)
		{
			DisplayAndPruneTag(apiSchema, implementedEndpoints, null);
		}

		public static void DisplayAndPruneTag(
			OpenApiDocument apiSchema,
			Dictionary<string, List<MethodDetails>> implementedEndpoints,
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
					implementedEndpoints.TryGetValue(pathKpv.Key, out var implementation);
					var existingImplementation = implementation?.SingleOrDefault(e => e.RefitAttribute.Method == refitMethod);

					if (existingImplementation != null)
					{
						implementedTable.AddRow(
							pathOperation.Key.ToString(),
							pathKpv.Key,
							pathOperation.Value.OperationId,
							string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)),
							existingImplementation?.Method.Name ?? string.Empty);
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
						? $"'{tagRestriction}' implemented endpoints"
						: "Remaining implemented endpoints",
					new Style(Color.Green));
				AnsiConsole.Write(implementedTable);
			}

			if (missingTable.Rows.Count > 0)
			{
				missingTable.Title(
					tagRestriction is not null
						? $"'{tagRestriction}' missing endpoints"
						: "Remaining missing endpoints",
					new Style(Color.Red));
				AnsiConsole.Write(missingTable);
			}
		}
	}
}
