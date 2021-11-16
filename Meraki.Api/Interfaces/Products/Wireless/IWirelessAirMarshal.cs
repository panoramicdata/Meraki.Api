namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessAirMarshal
{
	/// <summary>
	/// List Air Marshal scan results from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 7 days. (optional)</param>
	[Get("/networks/{networkId}/wireless/airMarshal")]
	Task<List<AirMarshal>> GetNetworkWirelessAirMarshalAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default
		);
}
