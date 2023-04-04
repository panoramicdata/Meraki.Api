namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsSamlRoles
{
	/// <summary>
	/// Create a SAML role
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationSamlRole">Body for creating a SAML role</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[Post("/organizations/{organizationId}/samlRoles")]
	Task<SamlRole> CreateOrganizationSamlRoleAsync(
		string organizationId,
		[Body] SamlRoleCreateRequest createOrganizationSamlRole,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Remove a SAML role
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="samlRoleId">The SAML role id</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[Delete("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
	Task DeleteOrganizationSamlRoleAsync(
		string organizationId,
		string samlRoleId,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Return a SAML role
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="samlRoleId">The SAML role id</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[Get("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
	Task<SamlRole> GetOrganizationSamlRoleAsync(
		string organizationId,
		string samlRoleId,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// List the SAML roles for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[Get("/organizations/{organizationId}/samlRoles")]
	Task<List<SamlRole>> GetOrganizationSamlRolesAsync(
		string organizationId,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Update a SAML role
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="samlRoleId">The SAML role id</param>
	/// <param name="updateOrganizationSamlRole">Body for updating a SAML role</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[Put("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
	Task<SamlRole> UpdateOrganizationSamlRoleAsync(
		string organizationId,
		string samlRoleId,
		[Body] SamlRoleUpdateRequest updateOrganizationSamlRole,
		CancellationToken cancellationToken);
}
