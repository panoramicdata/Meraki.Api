namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Saml Idp
/// </summary>
public interface IOrganizationsSamlIdp
{
	/// <summary>
	/// List the SAML IdPs in your organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/saml/idps")]
	Task<List<SamlIdp>> GetOrganizationSamlIdpsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a SAML IdP for your organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationSamlIdp">Body for creating a SAML IdP</param>
	/// <param name="cancellationToken"></param>
	[Post("/organizations/{organizationId}/saml/idps")]
	Task<List<SamlIdp>> CreateOrganizationSamlIdpAsync(
		string organizationId,
		[Body] SamlIdpsCreateRequest createOrganizationSamlIdp,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Get a SAML IdP from your organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="idpId">The IdP id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/saml/idps/{idpId}")]
	Task<SamlIdp> GetOrganizationSamlIdpAsync(
		string organizationId,
		string idpId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a SAML IdP in your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="idpId">The IdP id</param>
	/// <param name="updateOrganizationSamlIdp">Body for updating a SAML IdP</param>
	/// <param name="cancellationToken"></param>
	[Put("/organizations/{organizationId}/saml/idps/{idpId}")]
	Task<List<SamlIdp>> UpdateOrganizationSamlIdpAsync(
		string organizationId,
		string idpId,
		[Body] SamlIdpsCreateRequest updateOrganizationSamlIdp,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Remove a SAML IdP in your organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="idpId">The IdP id</param>
	/// <param name="cancellationToken"></param>
	[Delete("/organizations/{organizationId}/saml/idps/{idpId}")]
	Task DeleteOrganizationSamlIdpAsync(
		string organizationId,
		string idpId,
		CancellationToken cancellationToken = default);
}
