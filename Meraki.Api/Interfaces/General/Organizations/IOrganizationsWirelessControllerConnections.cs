namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessControllerConnections
{
	/// <summary>
	/// List of unassigned Catalyst access points and summary information
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerConnectionsUnassigned")]
	[Get("/organizations/{organizationId}/wirelessController/connections/unassigned")]
	Task<OrganizationWirelessControllerConnectionsUnassigned> GetOrganizationWirelessControllerConnectionsUnassignedAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
