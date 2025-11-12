namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations saml API endpoints
/// </summary>

public partial class OrganizationsSamlSection
{
	[RefitPromoteCalls]
	internal IOrganizationsSaml Saml { get; set; } = null!;
	/// <summary>
	/// List the SAML IdPs in your organization.
	/// </summary>

	public IOrganizationsSamlIdp Idp { get; internal set; } = null!;
}
