namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Provides functionality to retrieve packet loss information for wireless devices within an organization.
/// </summary>
/// <remarks>
/// This interface defines a method for listing the most recent packet loss data for wireless devices.
/// The data is paginated, and the caller can specify the number of entries per page.
/// </remarks>
public interface IWirelessDevicePacketLoss
{
	/// <summary>
	/// List the most recent packet loss information for wireless devices.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization ID.</param>
	/// <param name="networkIds">Filter results by network.</param>
	/// <param name="serials">Filter results by device serial number.</param>
	/// <param name="ssids">Filter results by SSID number.</param>
	/// <param name="bands">Filter results by band. Valid bands are: 2.4, 5, and 6.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. This parameter should not be defined by client applications.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. This parameter should not be defined by client applications.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 90 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 90 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched, in seconds. If specifying timespan, do not specify parameters t0 and t1. Must be between 300 and 7776000 seconds.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/organizations/{organizationId}/wireless/devices/packetLoss/byDevice")]
	Task<List<WirelessDevicePacketLoss>> GetOrganizationWirelessDevicesPacketLossAsync(
		string organizationId,
		IEnumerable<string>? networkIds = null,
		IEnumerable<string>? serials = null,
		IEnumerable<int>? ssids = null,
		IEnumerable<string>? bands = null,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		CancellationToken cancellationToken = default);
}
