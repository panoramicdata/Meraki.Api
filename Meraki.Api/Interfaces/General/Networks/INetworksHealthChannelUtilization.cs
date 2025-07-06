namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksHealthChannelUtilization
{
	/// <summary>
	/// Get the channel utilization over each radio for all APs in a network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="t1">The end of the	 timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
	/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 600. The default is 600.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 100. Default is 10.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkNetworkHealthChannelUtilization")]
	[Get("/networks/{networkId}/networkHealth/channelUtilization")]
	Task<List<ChannelUtilization>> GetNetworkNetworkHealthChannelUtilizationAsync(
		string networkId,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		int? resolution = null,
		int? perPage = 100,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default
		);
}
