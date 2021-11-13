namespace Meraki.Api.Sections.General.Networks;

public class NetworksEventsSection
{
	public INetworksEvents Events { get; internal set; } = null!;
	public INetworksEventsEventTypes EventsTypes { get; internal set; } = null!;
}
