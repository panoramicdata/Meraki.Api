using Meraki.ApiChecker;
using Meraki.ApiChecker.Extensions;
using PanoramicData.SheetMagic;
using System.Diagnostics;

Console.WriteLine($"{ThisAssembly.AssemblyName} v{ThisAssembly.AssemblyInformationalVersion}");

Console.Write("Getting implemented endpoints...");
var implementedEndpoints = InterfaceReader.GetEndPoints();
Console.WriteLine("done.");
Console.Write("Retrieving API schema...");
var apiSchema = await OpenApiReader.GetSchemaAsync().ConfigureAwait(false);
Console.WriteLine("done.");

Console.Write("Beginning build xlsx output...");
var configureEndpointSet = SheetOutput.CreateWorksheet(apiSchema, implementedEndpoints, "configure");
var monitorEndpointSet = SheetOutput.CreateWorksheet(apiSchema, implementedEndpoints, "monitor");
var liveToolsEndpointSet = SheetOutput.CreateWorksheet(apiSchema, implementedEndpoints, "liveTools");
var remainingTags = SheetOutput.CreateWorksheet(apiSchema, null, null);
var implementationsWithoutEndpoints = SheetOutput.GetRemainingInterfaces(implementedEndpoints);
var fileInfo = new FileInfo($"API Check {DateTime.UtcNow:yyyyMMddTHHmmss}.xlsx");
using var workbook = new MagicSpreadsheet(fileInfo);
configureEndpointSet.AddToWorkbook(workbook, "Configure");
monitorEndpointSet.AddToWorkbook(workbook, "Monitor");
liveToolsEndpointSet.AddToWorkbook(workbook, "Livetools");
remainingTags.AddToWorkbook(workbook, "Other");
if (implementationsWithoutEndpoints.Count > 0) { workbook.AddSheet(implementationsWithoutEndpoints, "Unmatched-Implementations"); }

workbook.Save();
Console.WriteLine(fileInfo.FullName);

// Open the file using shell to start whatever application is registered with the xlsx extension
var processStartInfo = new ProcessStartInfo(fileInfo.FullName)
{
	UseShellExecute = true
};
Process.Start(processStartInfo);
