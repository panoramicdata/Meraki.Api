namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectPrivateApplicationGroups
{
	/// <summary>
	/// Provides a list of private application groups for an Organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPrivateApplicationGroups")]
	[Get("/organizations/{organizationId}/secureConnect/privateApplicationGroups")]
	Task<SecureConnectPrivateApplicationGroups> GetOrganizationSecureConnectPrivateApplicationGroupsAsync(string organizationId, CancellationToken cancellationToken = default);

	/// <summary>
	/// Creates a group of private applications to apply to policy. A maximum of 300 private application groups are allowed for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="secureConnectPrivateAppplicationGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSecureConnectPrivateApplicationGroup")]
	[Post("/organizations/{organizationId}/secureConnect/privateApplicationGroups")]
	Task<SecureConnectPrivateApplicationGroup> CreateOrganizationSecureConnectPrivateApplicationGroupAsync(
		string organizationId,
		[Body] SecureConnectPrivateApplicationGroupCreateRequest secureConnectPrivateAppplicationGroup,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// 
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="applicationGroupId"></param>
	/// <param name="secureConnectPrivateAppplicationGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationSecureConnectPrivateApplicationGroup")]
	[Put("/organizations/{organizationId}/secureConnect/privateApplicationGroups/{applicationGroupId}")]
	Task<SecureConnectPrivateApplicationGroup> UpdateOrganizationSecureConnectPrivateApplicationGroupAsync(
		string organizationId,
		string applicationGroupId,
		[Body] SecureConnectPrivateApplicationGroupUpdateRequest secureConnectPrivateAppplicationGroup,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the details of a specific private application group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="applicationGroupId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPrivateApplicationGroup")]
	[Get("/organizations/{organizationId}/secureConnect/privateApplicationGroups/{applicationGroupId}")]
	Task<SecureConnectPrivateApplicationGroup> GetOrganizationSecureConnectPrivateApplicationGroupAsync(
		string organizationId,
		string applicationGroupId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Deletes private application group from an Organization. Detaches application from groups before deleting
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="applicationGroupId"></param>
	/// <param name="secureConnectPrivateAppplicationGroup"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSecureConnectPrivateApplicationGroup")]
	[Delete("/organizations/{organizationId}/secureConnect/privateApplicationGroups/{applicationGroupId}")]
	Task DeleteOrganizationSecureConnectPrivateApplicationGroupAsync(
		string organizationId,
		string applicationGroupId,
		[Body] SecureConnectPrivateApplicationGroupDeleteRequest secureConnectPrivateAppplicationGroup,
		CancellationToken cancellationToken = default
		);
}
