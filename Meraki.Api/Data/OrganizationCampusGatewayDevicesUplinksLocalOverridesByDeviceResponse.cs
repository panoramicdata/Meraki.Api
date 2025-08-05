namespace Meraki.Api.Data;

/// <summary>
/// Organization Campus Gateway Devices Uplinks Local Overrides By Device Response.
/// </summary>
[DataContract]
public class OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponse
{
	/// <summary>
	/// Other metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of Consilience entities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseItem> Items { get; set; } = [];
}
