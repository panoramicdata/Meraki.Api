namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Organizations Campus Gateway Devices Uplinks
/// </summary>
public class OrganizationsCampusGatewayDevicesUplinks
{
	/// <summary>
	/// Uplink overrides configured locally on Campus Gateway devices in an organization.
	/// </summary>

	public IOrganizationsCampusGatewayDevicesUplinksLocalOverrides LocalOverrides { get; internal set; } = null!;
}
