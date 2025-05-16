namespace Meraki.Api.Data;

/// <summary>
/// Meta data of the items
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesMetadataCountsItems
{
	/// <summary>
	/// Total number of scheduled packet captures
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}