namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Sm Admins
/// </summary>
public interface IOrganizationsSmAdmins
{
	/// <summary>
	/// List the Limited Access Roles for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSmAdminsRoles")]
	[Get("/organizations/{organizationId}/sm/admins/roles")]
	Task<OrganizationSmAdminsRolesResponse> GetOrganizationsSmAdminsRolesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a Limited Access Role
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="organizationSmAdminsRole"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSmAdminsRole")]
	[Post("/organizations/{organizationId}/sm/admins/roles")]
	Task<OrganizationSmAdminsRole> CreateOrganizationSmAdminsRoleAsync(
		string organizationId,
		[Body] OrganizationSmAdminsRoleCreateRequest organizationSmAdminsRole,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a Limited Access Role
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="roleId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSmAdminsRole")]
	[Get("/organizations/{organizationId}/sm/admins/roles/{roleId}")]
	Task<OrganizationSmAdminsRole> GetOrganizationSmAdminsRoleAsync(
		string organizationId,
		string roleId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a Limited Access Role
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="roleId"></param>
	/// <param name="organizationSmAdminsRole"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationSmAdminsRole")]
	[Put("/organizations/{organizationId}/sm/admins/roles/{roleId}")]
	Task<OrganizationSmAdminsRole> UpdateOrganizationSmAdminsRoleAsync(
		string organizationId,
		string roleId,
		[Body] OrganizationSmAdminsRoleUpdateRequest organizationSmAdminsRole,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a Limited Access Role
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="roleId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSmAdminsRole")]
	[Delete("/organizations/{organizationId}/sm/admins/roles/{roleId}")]
	Task DeleteOrganizationSmAdminsRoleAsync(
		string organizationId,
		string roleId,
		CancellationToken cancellationToken = default
		);
}
