namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksTraffic
{
	/// <summary>
	/// Return the traffic analysis data for this network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 30 days. (optional)</param>
	/// <param name="deviceType">Filter the data by device type: 'combined', 'wireless', 'switch' or 'appliance'. Defaults to 'combined'.     When using 'combined', for each rule the data will come from the device type with the most usage.  (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/traffic")]
	Task<List<NetworkTraffic>> GetNetworkTrafficAsync(
		string networkId,
		string t0 = null!,
		double? timespan = null,
		string deviceType = null!,
		CancellationToken cancellationToken = default
		);
}
