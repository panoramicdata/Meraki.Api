using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISamlIdps
	{
		/// <summary>
		/// List the SAML IdPs in your organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/saml/idps")]
		Task<List<SamlIdps>> GetOrganizationSamlIdpsAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Create a SAML IdP for your organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="CreateOrganizationSamlIdp">Body for creating a SAML IdP</param>
		[Post("/organizations/{organizationId}/saml/idps")]
		Task<SamlIdpsCreateRequest> CreateOrganizationSamlIdpAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] SamlIdpsCreateRequest CreateOrganizationSamlIdp,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Get a SAML IdP from your organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="idpId">The IdP id</param>
		[Get("/organizations/{organizationId}/saml/idps/{idpId}")]
		Task<SamlIdps> GetOrganizationSamlIdpAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("idpId")] string idpId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a SAML IdP in your organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="idpId">The IdP id</param>
		/// <param name="UpdateOrganizationSamlIdp">Body for updating a SAML IdP</param>
		[Put("/organizations/{organizationId}/saml/idps/{idpId}")]
		Task<SamlIdpsCreateRequest> UpdateOrganizationSamlIdpAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("idpId")] string idpId,
			[Body] SamlIdpsCreateRequest UpdateOrganizationSamlIdp,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Remove a SAML IdP in your organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="idpId">The IdP id</param>
		[Delete("/organizations/{organizationId}/saml/idps/{idpId}")]
		Task DeleteOrganizationSamlIdpAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("idpId")] string idpId,
			CancellationToken cancellationToken = default);
	}
}
