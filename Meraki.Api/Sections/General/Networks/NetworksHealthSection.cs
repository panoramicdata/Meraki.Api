namespace Meraki.Api.Sections.General.Networks;

public class NetworksHealthSection
{
	public INetworksHealthChannelUtilization ChannelUtilization { get; internal set; } = null!;

	public INetworksHealthAlerts HealthAlerts { get; internal set; } = null!;
}
