namespace Meraki.Api.Sections.Products.Appliance;

public partial class ApplianceContentFilteringSection
{
	[RefitPromoteCalls]
	internal IApplianceContentFiltering ContentFiltering { get; set; } = null!;
	/// <summary>
	/// List all available content filtering categories for an MX network
	/// </summary>

	public IApplianceContentFilteringCategories Categories { get; internal set; } = null!;
}
