namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceUplinksSection
{
	public IApplianceUplinksUsageHistory UsageHistory { get; internal set; } = null!;
	public IApplianceUplinksSettings Settings { get; internal set; } = null!;
}
