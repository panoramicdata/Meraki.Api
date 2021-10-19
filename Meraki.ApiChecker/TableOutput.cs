using BetterConsoleTables;
using Meraki.ApiChecker.Extensions;
using Meraki.ApiChecker.Models;
using Microsoft.OpenApi.Models;

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
			if (tagRestriction is not null)
			{
				Console.WriteLine($"'{tagRestriction}' endpoints");
			}
			else
			{
				Console.WriteLine("Remaining endpoints");
			}
			var table = new Table(TableConfiguration.Unicode(), "Method", "Endpoint", "OperationId", "Tags", "Method");
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

					table.AddRow(
						pathOperation.Key,
						pathKpv.Key,
						pathOperation.Value.OperationId,
						string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name)),
						existingImplementation?.Method.Name ?? string.Empty);

					pathKpv.Value.Operations.Remove(pathOperation);
				}
			}
			Console.Write(table.ToString());

		}
	}
}
