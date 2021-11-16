namespace Meraki.Api.Sections.General.Organizations;

public partial class OrganizationsSamlSection
{
	[RefitPromoteCalls]
	internal IOrganizationsSaml Saml { get; set; } = null!;
	public IOrganizationsSamlIdp Idp { get; internal set; } = null!;
}
