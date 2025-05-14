namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsInsightSection
{
	public IOrganizationsInsightApplications Applications { get; internal set; }

	public IOrganizationsInsightWebApps WebApps { get; internal set; }
}
