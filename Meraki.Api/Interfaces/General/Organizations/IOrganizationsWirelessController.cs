namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Wireless Controller
/// </summary>
public interface IOrganizationsWirelessController
{
	/// <summary>
	/// List all access points associated with wireless LAN controllers in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerConnections")]
	[Get("/organizations/{organizationId}/wirelessController/connections")]
	Task<OrganizationWirelessControllerConnections> GetOrganizationWirelessControllerConnectionsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
