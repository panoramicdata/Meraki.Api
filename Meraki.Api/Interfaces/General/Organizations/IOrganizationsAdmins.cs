namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Admins interface
/// </summary>
public interface IOrganizationsAdmins
{
	/// <summary>
	///	List the dashboard administrators in this organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/admins")]
	Task<List<Admin>> GetOrganizationAdminsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a new dashboard administrator
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationAdmin">Body for creating organization admin</param>
	/// <param name="cancellationToken"></param>
	[Post("/organizations/{organizationId}/admins")]
	Task<Admin> CreateOrganizationAdminAsync(
		string organizationId,
		[Body] AdminCreationRequest createOrganizationAdmin,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Revoke all access for a dashboard administrator within this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="adminId">The admin id</param>
	/// <param name="cancellationToken"></param>
	[Delete("/organizations/{organizationId}/admins/{adminId}")]
	Task DeleteOrganizationAdminAsync(
		string organizationId,
		string adminId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an administrator
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="adminId">The admin id</param>
	/// <param name="adminUpdateRequest">Body for updating admin</param>
	/// <param name="cancellationToken"></param>
	[Put("/organizations/{organizationId}/admins/{adminId}")]
	Task<Admin> UpdateOrganizationAdminAsync(
		string organizationId,
		string adminId,
		[Body] AdminUpdateRequest adminUpdateRequest,
		CancellationToken cancellationToken = default);
}
