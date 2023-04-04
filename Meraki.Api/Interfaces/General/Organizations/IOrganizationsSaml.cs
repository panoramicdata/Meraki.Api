namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsSaml
{
	/// <summary>
	/// Returns the SAML SSO enabled settings for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/saml")]
	Task<Saml> GetOrganizationSamlAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates the SAML SSO enabled settings for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="updateOrganizationSaml">Body for updating SAML SSO enabled settings</param>
	[Put("/organizations/{organizationId}/saml")]
	Task<Saml> UpdateOrganizationSamlAsync(
		string organizationId,
		[Body] Saml updateOrganizationSaml,
		CancellationToken cancellationToken = default
		);
}
