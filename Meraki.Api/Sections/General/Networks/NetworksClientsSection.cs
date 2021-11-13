namespace Meraki.Api.Sections.General.Networks
{
	public class NetworksClientsSection
	{
		public INetworksClients Clients { get; internal set; } = null!;
		public INetworksClientsApplicationUsage ApplicationUsage { get; internal set; } = null!;
		public INetworksClientsPolicy Policy { get; internal set; } = null!;
		public INetworksClientsSplashAuthorizationStatus SplashAuthorizationStatus { get; internal set; } = null!;
		public INetworksClientsTrafficHistory TrafficHistory { get; internal set; } = null!;
		public INetworksClientsUsageHistories UsageHistories { get; internal set; } = null!;
		public INetworksClientsUsageHistory UsageHistory { get; internal set; } = null!;
	}
}
