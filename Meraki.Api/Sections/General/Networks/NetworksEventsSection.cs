namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks events API endpoints
/// </summary>
public partial class NetworksEventsSection
{
	[RefitPromoteCalls]
	internal INetworksEvents Events { get; set; } = null!;
	/// <summary>
	/// List the event type to human-readable description
	/// </summary>

	public INetworksEventsEventTypes EventsTypes { get; internal set; } = null!;
}
