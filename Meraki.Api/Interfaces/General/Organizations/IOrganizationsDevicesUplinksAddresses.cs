namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Devices Uplinks Addresses
/// </summary>
public interface IOrganizationsDevicesUplinksAddresses
{
	/// <summary>
	/// List the current uplink addresses for devices in an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationDevicesUplinksAddressesByDevice")]
	[Get("/organizations/{organizationId}/devices/uplinks/addresses/byDevice")]
	Task<List<OrganizationDevicesUplinksAddressesByDeviceItem>> GetOrganizationDevicesUplinksAddressesByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
