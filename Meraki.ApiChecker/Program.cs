using Meraki.ApiChecker;

Console.WriteLine($"{ThisAssembly.AssemblyName} v{ThisAssembly.AssemblyInformationalVersion}");

var implementedEndpoints = InterfaceReader.GetEndPoints();
var apiSchema = await OpenApiReader.GetSchemaAsync();

// Get all the operations, then group into configure and monitor and other
TableOutput.DisplayAndPruneTag(apiSchema, implementedEndpoints, "configure");
TableOutput.DisplayAndPruneTag(apiSchema, implementedEndpoints, "monitor");
TableOutput.DisplayRemainingTags(apiSchema, implementedEndpoints);

