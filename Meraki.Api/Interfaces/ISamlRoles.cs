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
		/// createOrganizationSamlRole
		/// </summary>
		/// <remarks>
		/// Create a SAML role
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createOrganizationSamlRole"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/samlRoles")]
		Task<object> CreateOrganizationSamlRole(
			[AliasAs("organizationId")]string organizationId,
			[Body]CreateOrganizationSamlRole createOrganizationSamlRole
			);

		/// <summary>
		/// deleteOrganizationSamlRole
		/// </summary>
		/// <remarks>
		/// Remove a SAML role
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="samlRoleId"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
		Task DeleteOrganizationSamlRole(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("samlRoleId")]string samlRoleId
			);

		/// <summary>
		/// getOrganizationSamlRole
		/// </summary>
		/// <remarks>
		/// Return a SAML role
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="samlRoleId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
		Task<object> GetOrganizationSamlRole(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("samlRoleId")]string samlRoleId
			);

		/// <summary>
		/// getOrganizationSamlRoles
		/// </summary>
		/// <remarks>
		/// List the SAML roles for this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/samlRoles")]
		Task<object> GetOrganizationSamlRoles(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// updateOrganizationSamlRole
		/// </summary>
		/// <remarks>
		/// Update a SAML role
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="samlRoleId"></param>
		/// <param name="updateOrganizationSamlRole"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/samlRoles/{samlRoleId}")]
		Task<object> UpdateOrganizationSamlRole(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("samlRoleId")]string samlRoleId,
			[Body]UpdateOrganizationSamlRole updateOrganizationSamlRole);
	}
}
