namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWirelessRadioRfHealth
{
	/// <summary>
	/// Return the RF health metrics, by network, for all bands over time
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 182 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 30 days after t0. (optional)</param>
	/// <param name="timespan">The timespan, in seconds, for which the information will be fetched. If specifying timespan, do not specify t0 and t1. Must be less than or equal to 2,629,746 seconds (confirmed by the API, which returns a 400 one second above this). The default is 14 days. (optional)</param>
	/// <param name="interval">The time interval in seconds for returned data. Valid values are 7200 and 86400 - any other value returns a 400 "invalid interval". Confirmed the API silently widens the default from 7200 to 86400 for large timespans when this is omitted, so pass it explicitly for a predictable bucket size. (optional)</param>
	/// <param name="networkIds">Optional parameter to filter results by network.</param>
	/// <param name="bands">Optional parameter to filter results by band. Valid bands are 2.4, 5 and 6.</param>
	/// <param name="minimumRfHealthScore">Optional parameter to filter results by minimum RF health score.</param>
	/// <param name="maximumRfHealthScore">Optional parameter to filter results by maximum RF health score.</param>
	/// <param name="minimumHighCciPercentage">Optional parameter to filter results by minimum high CCI percentage.</param>
	/// <param name="maximumHighCciPercentage">Optional parameter to filter results by maximum high CCI percentage.</param>
	/// <param name="minimumChannelChanges">Optional parameter to filter results by minimum channel changes.</param>
	/// <param name="maximumChannelChanges">Optional parameter to filter results by maximum channel changes.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationWirelessRadioRfHealthOverviewByNetworkByInterval")]
	[Get("/organizations/{organizationId}/wireless/radio/rfHealth/overview/byNetwork/byInterval")]
	Task<OrganizationWirelessRadioRfHealthOverviewByNetworkByInterval> GetOrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		int? interval = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		[AliasAs("bands[]")] List<string>? bands = null,
		int? minimumRfHealthScore = null,
		int? maximumRfHealthScore = null,
		int? minimumHighCciPercentage = null,
		int? maximumHighCciPercentage = null,
		int? minimumChannelChanges = null,
		int? maximumChannelChanges = null,
		CancellationToken cancellationToken = default);
}
