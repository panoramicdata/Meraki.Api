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
