namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IWireless Device Packet Loss
/// </summary>
public static class IWirelessDevicePacketLossExtensions
{
	/// <summary>
	/// List the most recent packet loss information for wireless devices, fetching every page.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call.</exception>
	/// <param name="wirelessDevicePacketLoss"></param>
	/// <param name="organizationId">The organization ID.</param>
	/// <param name="networkIds">Filter results by network.</param>
	/// <param name="serials">Filter results by device serial number.</param>
	/// <param name="ssids">Filter results by SSID number.</param>
	/// <param name="bands">Filter results by band. Valid bands are: 2.4, 5, and 6.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 90 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 90 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched, in seconds. If specifying timespan, do not specify parameters t0 and t1. Must be between 300 and 7776000 seconds.</param>
	/// <param name="cancellationToken">Cancellation token to cancel the request.</param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<WirelessDevicePacketLoss>> GetOrganizationWirelessDevicesPacketLossAllAsync(
		this IWirelessDevicePacketLoss wirelessDevicePacketLoss,
		string organizationId,
		IEnumerable<string>? networkIds = null,
		IEnumerable<string>? serials = null,
		IEnumerable<int>? ssids = null,
		IEnumerable<string>? bands = null,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, endingBefore, cancellationToken)
			=> wirelessDevicePacketLoss.GetOrganizationWirelessDevicesPacketLossApiResponseAsync(
				organizationId,
				networkIds,
				serials,
				ssids,
				bands,
				startingAfter,
				endingBefore,
				t0,
				t1,
				timespan,
				cancellationToken
			),
			cancellationToken
		);
}
