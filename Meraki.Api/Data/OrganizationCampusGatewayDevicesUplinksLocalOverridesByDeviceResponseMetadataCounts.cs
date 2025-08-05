namespace Meraki.Api.Data;

/// <summary>
/// Count metadata related to this result set.
/// </summary>
[DataContract]
public class OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseMetadataCounts
{
	/// <summary>
	/// The count metadata.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseMetadataCountsItems Items { get; set; } = new();
}
