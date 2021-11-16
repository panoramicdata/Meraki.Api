namespace Meraki.Api.Sections.Products.Appliance;

public partial class ApplianceTrafficShapingSection
{
	[RefitPromoteCalls]
	internal IApplianceTrafficShaping TrafficShaping { get; set; } = null!;
	public IApplianceTrafficShapingCustomPerformanceClasses CustomPerformanceClasses { get; internal set; } = null!;
	public IApplianceTrafficShapingRules Rules { get; internal set; } = null!;
	public IApplianceTrafficShapingUplinkBandwidth UplinkBandwidth { get; internal set; } = null!;
	public IApplianceTrafficShapingUplinkSelection UplinkSelection { get; internal set; } = null!;
}
