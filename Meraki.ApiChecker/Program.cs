using Meraki.ApiChecker;

Console.WriteLine($"{ThisAssembly.AssemblyName} v{ThisAssembly.AssemblyInformationalVersion}");


Console.WriteLine("Getting deficient classes...");
var deficientClasses = ClassReader.GetDataClasses();
Console.WriteLine("done.");
Console.Write("Getting implemented endpoints...");
var implementedEndpoints = InterfaceReader.GetEndPoints(deficientClasses);
Console.WriteLine("done.");
Console.Write("Retrieving API schema...");
var apiSchema = await OpenApiReader.GetSchemaAsync().ConfigureAwait(false);
Console.WriteLine("done.");

TableOutput.DisplayAndPruneTag(apiSchema, implementedEndpoints, "configure");
TableOutput.DisplayAndPruneTag(apiSchema, implementedEndpoints, "monitor");
TableOutput.DisplayAndPruneTag(apiSchema, implementedEndpoints, "liveTools");

TableOutput.DisplayRemainingTags(apiSchema);
TableOutput.DisplayRemainingInterfaces(implementedEndpoints);