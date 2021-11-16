namespace Meraki.Api.Sections.Products.Appliance;

public partial class ApplianceVlansSection
{
	[RefitPromoteCalls]
	internal IApplianceVlans Vlans { get; set; } = null!;
	public IApplianceVlansSettings Settings { get; internal set; } = null!;
}