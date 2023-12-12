namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsSummarySection
{
	public IOrganizationsSummaryTop Top { get; set; } = null!;
	public IOrganizationsSummarySwitchPower SwitchPower { get; set; } = null!;
}
