namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsInsightSection
{
	[RefitPromoteCalls]
	internal IOrganizationsInsight Insight { get; set; } = null!;

	/// <summary>
	/// Add an Insight tracked application
	/// </summary>

	public IOrganizationsInsightApplications Applications { get; internal set; } = null!;

	/// <summary>
	/// Lists all default web applications rules with counter set rule ids
	/// </summary>

	public IOrganizationsInsightWebApps WebApps { get; internal set; } = null!;
}
