namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsVpnSection
{
	public OrganizationsVpnSiteToSiteSection SiteToSite { get; internal set; } = new();
}
