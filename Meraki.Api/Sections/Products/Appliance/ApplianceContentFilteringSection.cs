namespace Meraki.Api.Sections.Products.Appliance;

public partial class ApplianceContentFilteringSection
{
	[RefitPromoteCalls]
	internal IApplianceContentFiltering ContentFiltering { get; set; } = null!;
	public IApplianceContentFilteringCategories Categories { get; internal set; } = null!;
}
