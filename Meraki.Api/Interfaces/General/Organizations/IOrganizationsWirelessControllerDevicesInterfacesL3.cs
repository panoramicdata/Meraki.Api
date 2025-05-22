namespace Meraki.Api.Interfaces.General.Organizations;

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
}
