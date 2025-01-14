namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Status Counts Devices
/// </summary>
[DataContract]
public class FloorPlansAutoLocateStatusCountsDevices
{
	/// <summary>
	/// The total number of devices that will participate if an auto locate job is started
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
