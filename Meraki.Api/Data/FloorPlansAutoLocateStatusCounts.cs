namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Status Count
/// </summary>
[DataContract]
public class FloorPlansAutoLocateStatusCounts
{
	/// <summary>
	/// Device counts for this floor plan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public FloorPlansAutoLocateStatusCountsDevices Devices { get; set; } = new();

}
