// See https://aka.ms/new-console-template for more information
using BetterConsoleTables;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using Refit;
using System.Reflection;

Console.WriteLine($"{ThisAssembly.AssemblyName} v{ThisAssembly.AssemblyInformationalVersion}");

// Load our interface implementations
var apiAssembly = Assembly.Load("Meraki.Api");
var interfaces = apiAssembly
	.GetTypes()
	.Where(
		t => t.IsInterface
		&& t.Namespace!.StartsWith("Meraki.Api.Interfaces")
		).ToList();

var implementedEndpoints = new Dictionary<string, List<HttpMethodAttribute>>();

foreach (var iface in interfaces)
{
	// Look for all the methods and check for ones with Refit HttpMethodAttributes
	foreach (var method in iface.GetMethods())
	{
		var refitAttribute = method.GetCustomAttributes<HttpMethodAttribute>().FirstOrDefault();
		if (refitAttribute != null)
		{
			if (!implementedEndpoints.TryGetValue(refitAttribute.Path, out var existingList))
			{
				// Create a new list
				implementedEndpoints[refitAttribute.Path]
					= existingList
					= new List<HttpMethodAttribute>();
			}
			// Add the entry to the list
			existingList.Add(refitAttribute);
		}
	}
}

// Read the OpenApiSpec doc
var httpClient = new HttpClient
{
	BaseAddress = new Uri("https://raw.githubusercontent.com/meraki/openapi/")
};
var stream = await httpClient.GetStreamAsync("master/openapi/spec2.json");
var openApiDocument = new OpenApiStreamReader().Read(stream, out var diagnostic);
var table = new Table(TableConfiguration.Unicode(), "Method", "Endpoint", "OperationId", "Implemented");

foreach (var path in openApiDocument.Paths)
{
	foreach (var pathOperation in path.Value.Operations.Where(o => o.Value.Tags.Any(t => t.Name == "configure")))
	{
		var operation = pathOperation.Value;

		// Look for a matching operation
		var refitMethod = pathOperation.Key switch
		{
			OperationType.Get => HttpMethod.Get,
			OperationType.Put => HttpMethod.Put,
			OperationType.Post => HttpMethod.Post,
			OperationType.Delete => HttpMethod.Delete,
			OperationType.Options => HttpMethod.Options,
			OperationType.Head => HttpMethod.Head,
			OperationType.Patch => HttpMethod.Patch,
			OperationType.Trace => HttpMethod.Trace,
			_ => throw new NotSupportedException($"Cannot convert {nameof(OperationType)} {pathOperation.Key}"),
		};

		implementedEndpoints.TryGetValue(path.Key, out var implementation);
		var existingImplementation = implementation?.SingleOrDefault(e => e.Method == refitMethod);

		table.AddRow(pathOperation.Key, path.Key, operation.OperationId, existingImplementation is null ? "NO" : "Yes");
	}
}
Console.Write(table.ToString());
