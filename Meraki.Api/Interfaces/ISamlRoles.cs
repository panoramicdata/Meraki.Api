using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISamlRoles
	{
		/// <summary>
		/// Create a SAML role
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="createOrganizationSamlRole">Body for creating a SAML role</param>
		[Post("/organizations/{organizationId}/samlRoles")]
		Task<SamlRole> CreateOrganizationSamlRoleAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] SamlRoleCreateRequest createOrganizationSamlRole
			);

		/// <summary>
		/// Remove a SAML role
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="samlRoleId">The SAML role id</param>
		[Delete("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
		Task DeleteOrganizationSamlRoleAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("samlRoleId")] string samlRoleId
			);

		/// <summary>
		/// Return a SAML role
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="samlRoleId">The SAML role id</param>
		[Get("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
		Task<object> GetOrganizationSamlRoleAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("samlRoleId")] string samlRoleId
			);

		/// <summary>
		/// List the SAML roles for this organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/samlRoles")]
		Task<SamlRole> GetOrganizationSamlRolesAsync(
			[AliasAs("organizationId")] string organizationId
			);

		/// <summary>
		/// Update a SAML role
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="samlRoleId">The SAML role id</param>
		/// <param name="updateOrganizationSamlRole">Body for updating a SAML role</param>
		[Put("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
		Task<SamlRole> UpdateOrganizationSamlRoleAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("samlRoleId")] string samlRoleId,
			[Body] SamlRoleUpdateRequest updateOrganizationSamlRole);
	}
}
