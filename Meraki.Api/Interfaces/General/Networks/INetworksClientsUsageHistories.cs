namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksClientsUsageHistories
{
	/// <summary>
	/// Return the usage histories for clients.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clients">A list of client keys, MACs or IPs separated by comma.</param>
	/// <param name="ssidNumber">An SSID number to include. If not specified, eveusage histories application usagents for all SSIDs will be returned.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkClientsUsageHistories")]
	[Get("/networks/{networkId}/clients/usageHistories")]
	Task<List<ClientApplicationHistory>> GetNetworkClientsUsageHistoriesAsync(
		string networkId,
		string clients = null!,
		int? ssidNumber = null,
		int? perPage = 1000,
		string startingAfter = null!,
		string endingBefore = null!,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		CancellationToken cancellationToken = default);
}
