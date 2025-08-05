namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessClientsConnectionStats
{
	/// <summary>
	/// Aggregated connectivity info for this network, grouped by clients
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network ID</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
	/// <param name="band">Filter results by band (either '2.4' or '5'). Note that data prior to February 2020 will not have band information. (optional)</param>
	/// <param name="ssid">Filter results by SSID (optional)</param>
	/// <param name="vlan">Filter results by VLAN (optional)</param>
	/// <param name="apTag">Filter results by AP Tag (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/clients/connectionStats")]
	Task<List<NetworkClientConnectionStats>> GetNetworkWirelessClientsConnectionStatsAsync(
		string networkId,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		string band = null!,
		int? ssid = null,
		int? vlan = null,
		string apTag = null!,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Aggregated connectivity info for a given client on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network ID</param>
	/// <param name="clientId">The client ID (MAC)</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
	/// <param name="band">Filter results by band (either '2.4' or '5'). Note that data prior to February 2020 will not have band information. (optional)</param>
	/// <param name="ssid">Filter results by SSID (optional)</param>
	/// <param name="vlan">Filter results by VLAN (optional)</param>
	/// <param name="apTag">Filter results by AP Tag (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/clients/{clientId}/connectionStats")]
	Task<NetworkClientConnectionStats> GetNetworkWirelessClientConnectionStatsAsync(
		string networkId,
		string clientId,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		string band = null!,
		int? ssid = null,
		int? vlan = null,
		string apTag = null!,
		CancellationToken cancellationToken = default);
}
