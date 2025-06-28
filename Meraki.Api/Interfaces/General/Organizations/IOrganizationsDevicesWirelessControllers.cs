namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsDevicesWirelessControllers
{
	/// <summary>
	/// List of Catalyst access points information
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesWirelessControllersByDevice")]
	[Get("/organizations/{organizationId}/wireless/devices/wirelessControllers/byDevice")]
	Task<OrganizationWirelessDevicesWirelessControllersByDevice> GetOrganizationWirelessDevicesWirelessControllersByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
