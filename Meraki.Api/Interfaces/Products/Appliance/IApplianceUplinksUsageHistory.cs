namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceUplinksUsageHistory
{
	/// <summary>
	/// Get the sent and received bytes for each uplink of a network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 14 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 14 days. The default is 10 minutes.</param>
	/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 60, 300, 600, 1800, 3600, 86400. The default is 60.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/networks/{networkId}/appliance/uplinks/usageHistory")]
	Task<List<UplinkUsageHistory>> GetNetworkApplianceUplinksUsageHistoryAsync(
		string networkId,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		int? resolution = null,
		CancellationToken cancellationToken = default
		);
}
