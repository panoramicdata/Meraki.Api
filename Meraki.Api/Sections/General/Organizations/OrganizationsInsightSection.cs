namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsInsightSection
{
	[RefitPromoteCalls]
	internal IOrganizationsInsight Insight { get; set; } = null!;

	public IOrganizationsInsightApplications Applications { get; internal set; } = null!;

	public IOrganizationsInsightWebApps WebApps { get; internal set; } = null!;
}
