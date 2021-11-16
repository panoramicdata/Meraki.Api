namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceTrafficShapingSection
{
	public IApplianceTrafficShaping TrafficShaping { get; internal set; } = null!;
	public IApplianceTrafficShapingCustomPerformanceClasses CustomPerformanceClasses { get; internal set; } = null!;
	public IApplianceTrafficShapingRules Rules { get; internal set; } = null!;
	public IApplianceTrafficShapingUplinkBandwidth UplinkBandwidth { get; internal set; } = null!;
	public IApplianceTrafficShapingUplinkSelection UplinkSelection { get; internal set; } = null!;
}
