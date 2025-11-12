namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks traffic shaping API endpoints
/// </summary>
public class NetworksTrafficShapingSection
{
	/// <summary>
	/// Returns the application categories for traffic shaping rules.
	/// </summary>

	public INetworksTrafficShapingApplicationCategories ApplicationCategories { get; internal set; } = null!;
	/// <summary>
	/// Returns the available DSCP tagging options for your traffic shaping rules.
	/// </summary>

	public INetworksTrafficShapingDscpTaggingOptions DscpTaggingOptions { get; internal set; } = null!;
}
