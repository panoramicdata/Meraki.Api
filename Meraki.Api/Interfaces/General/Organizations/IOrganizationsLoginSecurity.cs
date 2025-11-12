namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Login Security
/// </summary>
public interface IOrganizationsLoginSecurity
{
	/// <summary>
	/// Returns the login security settings for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/loginSecurity")]
	Task<LoginSecurity> GetOrganizationLoginSecurityAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the login security settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="updateOrganizationLoginSecurity">Body for updating login settings</param>
	/// <param name="cancellationToken"></param>
	[Put("/organizations/{organizationId}/loginSecurity")]
	Task<LoginSecurity> UpdateOrganizationLoginSecurityAsync(
		string organizationId,
		[Body] LoginSecurity updateOrganizationLoginSecurity,
		CancellationToken cancellationToken = default);
}
