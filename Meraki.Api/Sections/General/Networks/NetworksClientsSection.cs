namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks clients API endpoints
/// </summary>
public partial class NetworksClientsSection
{
	[RefitPromoteCalls]
	internal INetworksClients Clients { get; set; } = null!;
	/// <summary>
	/// Return the application usage data for clients. Usage data is in kilobytes.
	/// </summary>

	public INetworksClientsApplicationUsage ApplicationUsage { get; internal set; } = null!;
	/// <summary>
	/// Return the policy assigned to a client on the network
	/// </summary>

	public INetworksClientsPolicy Policy { get; internal set; } = null!;
	/// <summary>
	/// Return the splash authorization for a client, for each SSID they've associated with through splash
	/// </summary>

	public INetworksClientsSplashAuthorizationStatus SplashAuthorizationStatus { get; internal set; } = null!;
	/// <summary>
	/// Return the client's network traffic data over time
	/// </summary>

	public INetworksClientsTrafficHistory TrafficHistory { get; internal set; } = null!;
	/// <summary>
	/// Return the usage histories for clients.
	/// </summary>

	public INetworksClientsUsageHistories UsageHistories { get; internal set; } = null!;
	/// <summary>
	/// Return the client's daily usage history
	/// </summary>

	public INetworksClientsUsageHistory UsageHistory { get; internal set; } = null!;
}
