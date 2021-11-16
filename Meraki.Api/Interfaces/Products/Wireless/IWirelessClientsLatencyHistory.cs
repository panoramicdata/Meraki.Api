namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessClientsLatencyHistory
{
	/// <summary>
	/// Return the latency history for a client
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientId">The client id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 791 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 791 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 791 days. The default is 1 day. (optional)</param>
	/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 86400. The default is 86400. (optional)</param>
	[Get("/networks/{networkId}/wireless/clients/{clientId}/latencyHistory")]
	Task<List<ClientLatencyHistory>> GetNetworkWirelessClientLatencyHistoryAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("clientId")] string clientId,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("t1")] string t1 = null!,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("resolution")] int? resolution = null,
		CancellationToken cancellationToken = default);
}
