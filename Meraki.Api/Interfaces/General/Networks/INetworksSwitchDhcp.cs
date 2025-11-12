namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks Switch Dhcp
/// </summary>
public interface INetworksSwitchDhcp
{
	/// <summary>
	/// Return the network's DHCPv4 servers seen within the selected timeframe (default 1 day)
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkSwitchDhcpV4ServersSeen")]
	[Get("/networks/{networkId}/switch/dhcp/v4/servers/seen")]
	Task<List<NetworksSwitchDhcpV4ServersSeen>> GetNetworkSwitchDhcpV4ServersSeenAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);
}
