namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance traffic shaping API endpoints
/// </summary>

public partial class ApplianceTrafficShapingSection
{
	[RefitPromoteCalls]
	internal IApplianceTrafficShaping TrafficShaping { get; set; } = null!;
	/// <summary>
	/// List all custom performance classes for an MX network
	/// </summary>

	public IApplianceTrafficShapingCustomPerformanceClasses CustomPerformanceClasses { get; internal set; } = null!;
	/// <summary>
	/// Display the traffic shaping settings rules for an MX network
	/// </summary>

	public IApplianceTrafficShapingRules Rules { get; internal set; } = null!;
	/// <summary>
	/// Returns the uplink bandwidth limits for your MX network.
	/// </summary>

	public IApplianceTrafficShapingUplinkBandwidth UplinkBandwidth { get; internal set; } = null!;
	/// <summary>
	/// Show uplink selection settings for an MX network
	/// </summary>

	public IApplianceTrafficShapingUplinkSelection UplinkSelection { get; internal set; } = null!;
	/// <summary>
	/// Display VPN exclusion rules for MX networks.
	/// </summary>

	public IApplianceTrafficShapingVpnExclusions VpnExclusions { get; internal set; } = null!;
}
