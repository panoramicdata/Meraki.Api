namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceContentFilteringSection
{
	public IApplianceContentFiltering ContentFiltering { get; internal set; } = null!;
	public IApplianceContentFilteringCategories Categories { get; internal set; } = null!;
}
