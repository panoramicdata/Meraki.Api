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
	[Get("/networks/{networkId}/wireless/clients/connectionStats")]
	Task<List<NetworkClientConnectionStats>> GetNetworkWirelessClientsConnectionStatsAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("t1")] string t1 = null!,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("band")] string band = null!,
		[AliasAs("ssid")] int? ssid = null,
		[AliasAs("vlan")] int? vlan = null,
		[AliasAs("apTag")] string apTag = null!,
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
	[Get("/networks/{networkId}/wireless/clients/{clientId}/connectionStats")]
	Task<NetworkClientConnectionStats> GetNetworkWirelessClientConnectionStatsAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("clientId")] string clientId,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("t1")] string t1 = null!,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("band")] string band = null!,
		[AliasAs("ssid")] int? ssid = null,
		[AliasAs("vlan")] int? vlan = null,
		[AliasAs("apTag")] string apTag = null!,
		CancellationToken cancellationToken = default);
}
