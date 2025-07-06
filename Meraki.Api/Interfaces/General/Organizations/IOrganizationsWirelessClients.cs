namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessClients
{
	/// <summary>
	/// List access point client count at the moment in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessClientsOverviewByDevice")]
	[Get("/organizations/{organizationId}/wireless/clients/overview/byDevice")]
	Task<OrganizationsWirelessControllerClientsOverviewByDevice> GetOrganizationWirelessClientsOverviewByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
