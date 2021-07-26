using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
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
	}
}
