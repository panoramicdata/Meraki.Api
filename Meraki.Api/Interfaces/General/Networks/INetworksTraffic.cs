namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksTraffic
{
	/// <summary>
	/// Return the traffic analysis data for this network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 30 days. (optional)</param>
	/// <param name="deviceType">Filter the data by device type: &#39;combined&#39;, &#39;wireless&#39;, &#39;switch&#39; or &#39;appliance&#39;. Defaults to &#39;combined&#39;.     When using &#39;combined&#39;, for each rule the data will come from the device type with the most usage.  (optional)</param>
	[Get("/networks/{networkId}/traffic")]
	Task<List<NetworkTraffic>> GetNetworkTrafficAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("deviceType")] string deviceType = null!,
		CancellationToken cancellationToken = default
		);
}
