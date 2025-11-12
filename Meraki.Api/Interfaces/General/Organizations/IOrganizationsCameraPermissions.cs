namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Camera Permissions
/// </summary>
public interface IOrganizationsCameraPermissions
{
	/// <summary>
	/// List the permissions scopes for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCameraPermissions")]
	[Get("/organizations/{organizationId}/camera/permissions")]
	Task<List<OrganizationCameraPermission>> GetOrganizationCameraPermissionsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Retrieve a single permission scope
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="permissionScopeId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCameraPermission")]
	[Get("/organizations/{organizationId}/camera/permissions/{permissionScopeId}")]
	Task<OrganizationCameraPermission> GetOrganizationCameraPermissionAsync(
		string organizationId,
		string permissionScopeId,
		CancellationToken cancellationToken = default
	);
}
