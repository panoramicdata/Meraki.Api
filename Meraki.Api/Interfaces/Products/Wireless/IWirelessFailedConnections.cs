namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessFailedConnections
{
	/// <summary>
	/// List of all failed client connection events on this network in a given time range
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
	/// <param name="band">Filter results by band (either '2.4' or '5'). Note that data prior to February 2020 will not have band information. (optional)</param>
	/// <param name="ssid">Filter results by SSID (optional)</param>
	/// <param name="vlan">Filter results by VLAN (optional)</param>
	/// <param name="apTag">Filter results by AP Tag (optional)</param>
	/// <param name="serial">Filter by AP (optional)</param>
	/// <param name="clientId">Filter by client MAC (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/failedConnections")]
	Task<List<FailedConnection>> GetNetworkWirelessFailedConnectionsAsync(
		string networkId,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		string band = null!,
		int? ssid = null,
		int? vlan = null,
		string apTag = null!,
		string serial = null!,
		string clientId = null!,
		CancellationToken cancellationToken = default);
}
