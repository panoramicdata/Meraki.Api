using Meraki.ApiChecker.Data;
using PanoramicData.SheetMagic;

namespace Meraki.ApiChecker.Extensions;
internal static class EndpointExtensions
{
	internal static void AddToWorkbook(this EndpointSet endpointSet, MagicSpreadsheet workbook, string setName)
	{
		if (endpointSet.ImplementedEndpoints.Count > 0) { workbook.AddSheet(endpointSet.ImplementedEndpoints, setName + "-Implemented"); }

		if (endpointSet.DuplicatedEndpoints.Count > 0) { workbook.AddSheet(endpointSet.DuplicatedEndpoints, setName + "-Duplicated"); }

		if (endpointSet.MissingEndpoints.Count > 0) { workbook.AddSheet(endpointSet.MissingEndpoints, setName + "-Missing"); }
	}
}
