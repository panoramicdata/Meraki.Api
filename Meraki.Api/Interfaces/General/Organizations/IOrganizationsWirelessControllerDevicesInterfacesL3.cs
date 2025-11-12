namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Wireless Controller Devices Interfaces L3
/// </summary>
public interface IOrganizationsWirelessControllerDevicesInterfacesL3
{
	/// <summary>
	/// List wireless LAN controller layer 3 interfaces in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesInterfacesL3ByDevice")]
	[Get("/organizations/{organizationId}/wirelessController/devices/interfaces/l3/byDevice")]
	Task<OrganizationWirelessControllerDevicesInterfacesL3ByDeviceResponse> GetOrganizationWirelessControllerDevicesInterfacesL3ByDeviceResponseAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List wireless LAN controller layer 3 interfaces history status in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDevice")]
	[Get("/organizations/{organizationId}/wirelessController/devices/interfaces/l3/statuses/changeHistory/byDevice")]
	Task<OrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDeviceResponse> GetOrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDeviceResponseAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List wireless LAN controller layer 3 interfaces history usage in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesInterfacesL3UsageHistoryByInterval")]
	[Get("/organizations/{organizationId}/wirelessController/devices/interfaces/l3/usage/history/byInterval")]
	Task<OrganizationWirelessControllerDevicesInterfacesL3UsageHistoryByIntervalResponse> GetOrganizationWirelessControllerDevicesInterfacesL3UsageHistoryByIntervalResponseAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
