namespace Meraki.Api.Sections.General.Networks;

public class NetworksPiiSection
{
	public INetworksPiiPiiKeys PiiKeys { get; internal set; } = null!;
	public INetworksPiiRequests Requests { get; internal set; } = null!;
	public INetworksPiiSmDevicesForKey SmDevicesForKey { get; internal set; } = null!;
	public INetworksPiiSmOwnersForKey SmOwnersForKey { get; internal set; } = null!;
}