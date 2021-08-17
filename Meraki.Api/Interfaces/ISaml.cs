using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISaml
	{
		/// <summary>
		/// Returns the SAML SSO enabled settings for an organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/saml")]
		Task<Saml> GetOrganizationSamlAsync(
			[AliasAs("organizationId")]string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates the SAML SSO enabled settings for an organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="UpdateOrganizationSaml">Body for updating SAML SSO enabled settings</param>
		[Put("/organizations/{organizationId}/saml")]
		Task<Saml> UpdateOrganizationSamlAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] Saml UpdateOrganizationSaml,
			CancellationToken cancellationToken = default
			);
	}
}
