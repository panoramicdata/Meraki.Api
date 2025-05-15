namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsAuthRadius
{
	/// <summary>
	/// List the organization-wide RADIUS servers in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationAuthRadiusServers")]
	[Get("/organizations/{organizationId}/auth/radius/servers")]
	Task<List<OrganizationsAuthRadiusServer>> GetOrganizationAuthRadiusServersAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
