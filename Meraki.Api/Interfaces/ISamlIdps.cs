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
		/// getOrganizationSamlIdps
		/// </summary>
		/// <remarks>
		/// List the SAML IdPs in your organization.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/saml/idps")]
		Task<List<SamlIdps>> GetOrganizationSamlIdps(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// createOrganizationSamlIdp
		/// </summary>
		/// <remarks>
		/// Create a SAML IdP for your organization.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createOrganizationSamlIdp"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/saml/idps")]
		Task<SamlIdpsCreateRequest> CreateOrganizationSamlIdpAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body]SamlIdpsCreateRequest createOrganizationSamlIdp
			);

		/// <summary>
		/// getOrganizationSamlIdp
		/// </summary>
		/// <remarks>
		/// Get a SAML IdP from your organization.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="idpId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/saml/idps/{idpId}")]
		Task<SamlIdps> GetOrganizationSamlIdp(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("idpId")] string idpId
			);

		/// <summary>
		/// updateOrganizationSamlIdp
		/// </summary>
		/// <remarks>
		/// Update a SAML IdP in your organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="idpId"></param>
		/// <param name="updateOrganizationSamlIdp"></param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/saml/idps/{idpId}")]
		Task<SamlIdpsCreateRequest> UpdateOrganizationSamlIdp(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("idpId")] string idpId,
			[Body] SamlIdpsCreateRequest updateOrganizationSamlIdp
			);

		/// <summary>
		/// deleteOrganizationSamlIdp
		/// </summary>
		/// <remarks>
		/// Remove a SAML IdP in your organization.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="idpId"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/saml/idps/{idpId}")]
		Task DeleteOrganizationSamlIdp(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("idpId")] string idpId,
			CancellationToken cancellationToken = default);
	}
}
