using Meraki.ApiChecker;
using PanoramicData.SheetMagic;

Console.WriteLine($"{ThisAssembly.AssemblyName} v{ThisAssembly.AssemblyInformationalVersion}");

Console.Write("Getting implemented endpoints...");
var implementedEndpoints = InterfaceReader.GetEndPoints();
Console.WriteLine("done.");
Console.Write("Retrieving API schema...");
var apiSchema = await OpenApiReader.GetSchemaAsync().ConfigureAwait(false);
Console.WriteLine("done.");
/*
TableOutput.DisplayAndPruneTag(apiSchema, implementedEndpoints, "configure");
TableOutput.DisplayAndPruneTag(apiSchema, implementedEndpoints, "monitor");
TableOutput.DisplayAndPruneTag(apiSchema, implementedEndpoints, "liveTools");

TableOutput.DisplayRemainingTags(apiSchema);
TableOutput.DisplayRemainingInterfaces(implementedEndpoints);
*/
Console.Write("Beginning build xlsx output...");
var configureImplemented = SheetOutput.CreateWorksheet(apiSchema, implementedEndpoints, "configure");
var monitorImplemented = SheetOutput.CreateWorksheet(apiSchema, implementedEndpoints, "monitor");
var liveToolsImplemented = SheetOutput.CreateWorksheet(apiSchema, implementedEndpoints, "liveTools");
var fileInfo = new FileInfo($"API Check {DateTime.UtcNow:yyyyMMddTHHmmss}.xlsx");
using var workbook = new MagicSpreadsheet(fileInfo);
workbook.AddSheet(configureImplemented, "Configure-Implemented");
workbook.AddSheet(monitorImplemented, "Monitor-Implemented");
workbook.AddSheet(liveToolsImplemented, "LiveTools-Implemented");
workbook.Save();
Console.WriteLine(fileInfo.FullName);