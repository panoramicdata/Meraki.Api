namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless controller devices system API endpoints
/// </summary>
public class OrganizationsWirelessControllerDevicesSystemSection
{
	/// <summary>
	/// Gets the utilization
	/// </summary>

	public OrganizationsWirelessControllerDevicesSystemUtilization Utilization { get; internal set; } = new();
}
