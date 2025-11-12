namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Wireless Controller Devices Interfaces Packets
/// </summary>
public interface IOrganizationsWirelessControllerDevicesInterfacesPackets
{
	/// <summary>
	/// Retrieve the packet counters for the interfaces of a Wireless LAN controller
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDevice")]
	[Get("/organizations/{organizationId}/wirelessController/devices/interfaces/packets/overview/byDevice")]
	Task<OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDevice> GetOrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
