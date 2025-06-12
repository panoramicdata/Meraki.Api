namespace Meraki.Api.Data;

/// <summary>
/// Counts of the result
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesMetadataCounts
{
	/// <summary>
	/// Meta data of the items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationDevicesPacketCaptureSchedulesMetadataCountsItems Items { get; set; } = new();
}
