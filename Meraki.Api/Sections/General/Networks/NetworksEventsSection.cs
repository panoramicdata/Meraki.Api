namespace Meraki.Api.Sections.General.Networks;

public partial class NetworksEventsSection
{
	[RefitPromoteCalls]
	internal INetworksEvents Events { get; set; } = null!;
	public INetworksEventsEventTypes EventsTypes { get; internal set; } = null!;
}
