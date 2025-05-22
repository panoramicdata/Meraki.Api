namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessControllerDevicesInterfacesL2
{
	/// <summary>
	/// List wireless LAN controller layer 2 interfaces in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesInterfacesL2ByDevice")]
	[Get("/organizations/{organizationId}/wirelessController/devices/interfaces/l2/byDevice")]
	Task<OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponse> GetOrganizationWirelessControllerDevicesInterfacesL2ByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// List wireless LAN controller layer 2 interfaces history status in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesInterfacesL2StatusesChangeHistoryByDevice")]
	[Get("/organizations/{organizationId}/wirelessController/devices/interfaces/l2/statuses/changeHistory/byDevice")]
	Task<OrganizationWirelessControllerDevicesInterfacesL2StatusesChangeHistoryByDeviceGetResponse> GetOrganizationWirelessControllerDevicesInterfacesL2StatusesChangeHistoryByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
