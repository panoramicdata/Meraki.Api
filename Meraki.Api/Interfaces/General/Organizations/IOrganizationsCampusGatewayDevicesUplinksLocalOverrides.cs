namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Campus Gateway Devices Uplinks Local Overrides
/// </summary>
public interface IOrganizationsCampusGatewayDevicesUplinksLocalOverrides
{
	/// <summary>
	/// Uplink overrides configured locally on Campus Gateway devices in an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCampusGatewayDevicesUplinksLocalOverridesByDevice")]
	[Get("/organizations/{organizationId}/campusGateway/devices/uplinks/localOverrides/byDevice")]
	Task<OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponse> GetOrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
