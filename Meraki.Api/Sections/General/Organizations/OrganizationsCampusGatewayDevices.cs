namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Organizations Campus Gateway Devices
/// </summary>
public class OrganizationsCampusGatewayDevices
{
	/// <summary>
	/// Gets the uplinks
	/// </summary>

	public OrganizationsCampusGatewayDevicesUplinks Uplinks { get; internal set; } = new();
}
