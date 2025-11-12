namespace Meraki.Api.Sections.General.Organizations;

public partial class OrganizationsSamlSection
{
	[RefitPromoteCalls]
	internal IOrganizationsSaml Saml { get; set; } = null!;
	/// <summary>
	/// List the SAML IdPs in your organization.
	/// </summary>

	public IOrganizationsSamlIdp Idp { get; internal set; } = null!;
}
