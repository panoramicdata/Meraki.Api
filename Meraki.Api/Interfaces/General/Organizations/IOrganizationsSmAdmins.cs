namespace Meraki.Api.Interfaces.General.Organizations;
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
}
