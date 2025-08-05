namespace Meraki.Api.Data;

/// <summary>
/// Counts of the result
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesMetadataCounts
{
	/// <summary>
	/// Meta data of the items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationDevicesPacketCaptureCapturesMetadataCountsItems Items { get; set; } = new();
}
