namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations summary API endpoints
/// </summary>
public class OrganizationsSummarySection
{
	/// <summary>
	/// Return the top 10 appliances sorted by utilization over given time range.
	/// </summary>

	public IOrganizationsSummaryTop Top { get; set; } = null!;
	/// <summary>
	/// Returns the total PoE power draw for all switch ports in the organization over the requested timespan (by default the last 24 hours).
	/// </summary>

	public IOrganizationsSummarySwitchPower SwitchPower { get; set; } = null!;
}
