using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkHealth
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
		[Get("/networks/{networkId}/networkHealth/channelUtilization")]
		Task<List<ChannelUtilization>> GetNetworkNetworkHealthChannelUtilizationAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("resolution")] int? resolution = null,
			[AliasAs("perPage")] int? perPage = 100,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return AP channel utilization over time for a device or network client
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
		/// <param name="t1">The end of the	 timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
		/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 600. The default is 600.</param>
		/// <param name="autoResolution">Automatically select a data resolution based on the given timespan; this overrides the value specified by the 'resolution' parameter. The default setting is false.</param>
		/// <param name="clientId">Filter results by network client to return per-device, per-band AP channel utilization metrics inner joined by the queried client's connection history.</param>
		/// <param name="deviceSerial">Filter results by device to return AP channel utilization metrics for the queried device; either :band or :clientId must be jointly specified.</param>
		/// <param name="apTag">Filter results by AP tag to return AP channel utilization metrics for devices labeled with the given tag; either :clientId or :deviceSerial must be jointly specified.</param>
		/// <param name="band">Filter results by band (either '2.4' or '5').</param>
		[Get("/networks/{networkId}/wireless/channelUtilizationHistory")]
		Task<List<ChannelUtilizationHistory>> GetNetworkWirelessChannelUtilizationHistoryAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("resolution")] int? resolution = null,
			[AliasAs("autoResolution")] bool? autoResolution = null,
			[AliasAs("clientId")] string? clientId = null,
			[AliasAs("deviceSerial")] string? deviceSerial = null,
			[AliasAs("apTag")] string? apTag = null,
			[AliasAs("band")] string? band = null,
			CancellationToken cancellationToken = default
			);
	}
}