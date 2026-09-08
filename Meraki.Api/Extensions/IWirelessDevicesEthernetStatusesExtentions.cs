namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for wireless devices ethernet statuses
/// </summary>
public static class IWirelessDevicesEthernetStatusesExtentions
{
	/// <summary>
	/// Get all power statuses for wireless devices
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="wirelessDeviceEthernetStatuses"></param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<WirelessDeviceEthernetStatus>> GetOrganizationWirelessDevicesEthernetStatusesAllAsync(
		this IWirelessDeviceEthernetStatuses wirelessDeviceEthernetStatuses,
		string organizationId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> wirelessDeviceEthernetStatuses.GetOrganizationWirelessDevicesEthernetStatusesApiResponseAsync(
						organizationId,
						startingAfter,
						endingBefore,
						cancellationToken
					),
					cancellationToken
			);
}
