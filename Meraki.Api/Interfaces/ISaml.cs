using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISaml
	{
		/// <summary>
		/// getOrganizationSaml
		/// </summary>
		/// <remarks>
		/// Returns the SAML SSO enabled settings for an organization.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/saml")]
		Task<Saml> GetOrganizationSaml(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// updateOrganizationSaml
		/// </summary>
		/// <remarks>
		/// Updates the SAML SSO enabled settings for an organization.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="updateOrganizationSaml"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/saml")]
		Task<Saml> UpdateOrganizationSaml(
			[AliasAs("organizationId")] string organizationId,
			[Body] Saml updateOrganizationSaml);
	}
}
