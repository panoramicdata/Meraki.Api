namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsSummarySection
{
	public IOrganizationsSummaryTop Top { get; set; } = null!;
	public IOrganizationsSummary Summary { get; set; } = null!;
}
