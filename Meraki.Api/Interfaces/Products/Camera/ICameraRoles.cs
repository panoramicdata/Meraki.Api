namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraRoles
{
	/// <summary>
	/// Creates new role for this organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="cameraRole">Camera Role</param>
	[ApiOperationId("createOrganizationCameraRole")]
	[Post("/organizations/{organizationId}/camera/roles")]
	Task<CameraRole> CreateOrganizationCameraRoleAsync(
		string organizationId,
		[Body] CameraRole cameraRole,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List all the roles in this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	[ApiOperationId("getOrganizationCameraRoles")]
	[Get("/organizations/{organizationId}/camera/roles")]
	Task<List<CameraRole>> GetOrganizationCameraRolesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Retrieve a single role.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="roleId">Role ID</param>
	[ApiOperationId("getOrganizationCameraRole")]
	[Get("/organizations/{organizationId}/camera/roles/{roleId}")]
	Task<CameraRole> GetOrganizationCameraRoleAsync(
		string organizationId,
		string roleId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update an existing role in this organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="cameraRole">Camera Role</param>
	[ApiOperationId("updateOrganizationCameraRole")]
	[Put("/organizations/{organizationId}/camera/role/{roleId}")]
	Task<CameraRole> UpdateOrganizationCameraRoleAsync(
		string organizationId,
		string roleId,
		[Body] CameraRole cameraRole,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete an existing role for this organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="roleId">The role id</param>
	[ApiOperationId("deleteOrganizationCameraRole")]
	[Delete("/organizations/{organizationId}/camera/roles/{roleId}")]
	Task DeleteOrganizationCameraRoleAsync(
		string organizationId,
		string roleId,
		CancellationToken cancellationToken = default
		);
}
