namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceTrafficShapingSection
{
	public IApplicationTrafficShaping TrafficShaping { get; internal set; } = null!;
	public IApplicationTrafficShapingCustomPerformanceClasses CustomPerformanceClasses { get; internal set; } = null!;
	public IApplicationTrafficShapingRules Rules { get; internal set; } = null!;
	public IApplicationTrafficShapingUplinkBandwidth UplinkBandwidth { get; internal set; } = null!;
	public IApplicationTrafficShapingUplinkSelection UplinkSelection { get; internal set; } = null!;
}
