namespace Meraki.Api.Data;

/// <summary>
/// Other metadata related to this result set.
/// </summary>
[DataContract]
public class OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseMetadata
{
	/// <summary>
	/// Count metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseMetadataCounts Counts { get; set; } = new();
}
