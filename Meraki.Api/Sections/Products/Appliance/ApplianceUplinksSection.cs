namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance uplinks API endpoints
/// </summary>
public class ApplianceUplinksSection
{
	/// <summary>
	/// Get the sent and received bytes for each uplink of a network.
	/// </summary>

	public IApplianceUplinksUsageHistory UsageHistory { get; internal set; } = null!;
	/// <summary>
	/// Gets the
	/// </summary>

	public IApplianceUplinksSettings Settings { get; internal set; } = null!;
	/// <summary>
	/// Gets the statuses overview
	/// </summary>

	public IApplianceUplinksStatusesOverview StatusesOverview { get; internal set; } = null!;
}
