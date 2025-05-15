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

	/// <summary>
	/// Add an organization-wide RADIUS server
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationAuthRadiusServer")]
	[Post("/organizations/{organizationId}/auth/radius/servers")]
	Task<OrganizationsAuthRadiusServer> CreateOrganizationAuthRadiusServerAsync(
		string organizationId,
		[Body] OrganizationsAuthRadiusServerCreateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Return an organization-wide RADIUS server
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="serverId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationAuthRadiusServer")]
	[Get("/organizations/{organizationId}/auth/radius/servers/{serverId}")]
	Task<OrganizationsAuthRadiusServer> GetOrganizationsAuthRadiusServerAsync(
		string organizationId,
		string serverId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update an organization-wide RADIUS server
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="serverId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationAuthRadiusServer")]
	[Put("/organizations/{organizationId}/auth/radius/servers/{serverId}")]
	Task<OrganizationsAuthRadiusServer> UpdateOrganizationAuthRadiusServerAsync(
		string organizationId,
		string serverId,
		[Body] OrganizationsAuthRadiusServerUpdateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Delete an organization-wide RADIUS server from a organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="serverId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationAuthRadiusServer")]
	[Delete("/organizations/{organizationId}/auth/radius/servers/{serverId}")]
	Task DeleteOrganizationAuthRadiusServerAsync(
		string organizationId,
		string serverId,
		CancellationToken cancellationToken = default
	);
}
