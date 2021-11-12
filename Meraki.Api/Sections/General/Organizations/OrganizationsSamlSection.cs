namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsSamlSection
{
	public IOrganizationsSaml Saml { get; internal set; } = null!;
	public IOrganizationsSamlIdp Idp { get; internal set; } = null!;
}
