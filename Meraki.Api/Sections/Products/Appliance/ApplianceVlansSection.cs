namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceVlansSection
{
	public IApplianceVlans Vlans { get; internal set; } = null!;
	public IApplianceVlansSettings Settings { get; internal set; } = null!;
}