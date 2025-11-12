namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Wireless Controller Devices Interfaces Usage
/// </summary>
public interface IOrganizationsWirelessControllerDevicesInterfacesUsage
{
	/// <summary>
	/// Retrieve the traffic for the interfaces of a Wireless LAN controller
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesInterfacesUsageHistoryByInterval")]
	[Get("/organizations/{organizationId}/wirelessController/devices/interfaces/usage/history/byInterval")]
	Task<OrganizationWirelessControllerDevicesInterfacesUsageHistoryByInterval> GetOrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalAsync(string organizationId, CancellationToken cancellationToken = default);
}
