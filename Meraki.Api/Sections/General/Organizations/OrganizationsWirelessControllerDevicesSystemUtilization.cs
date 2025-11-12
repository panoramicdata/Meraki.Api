namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Organizations Wireless Controller Devices System Utilization
/// </summary>
public class OrganizationsWirelessControllerDevicesSystemUtilization
{
	/// <summary>
	/// List cpu utilization data of wireless LAN controllers in an organization
	/// </summary>

	public IOrganizationsWirelessControllerDevicesSystemUtilizationHistory History { get; internal set; } = null!;
}
