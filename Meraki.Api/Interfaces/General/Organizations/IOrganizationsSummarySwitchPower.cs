namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Organizations Summary
/// </summary>
public interface IOrganizationsSummarySwitchPower
{
	/// <summary>
	/// Returns the total PoE power draw for all switch ports in the organization over the requested timespan (by default the last 24 hours).
	/// The returned array is a newest-first list of intervals.
	/// The time between intervals depends on the requested timespan with 20 minute intervals used for timespans up to 1 day,
	/// 4 hour intervals used for timespans up to 2 weeks, and 1 day intervals for timespans larger than 2 weeks.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. Maximum = 2678400</param>
	[ApiOperationId("getOrganizationSummarySwitchPowerHistory")]
	[Get("/organizations/{organizationId}/summary/switch/power/history")]
	Task<List<SwitchPowerHistorySummary>> GetOrganizationSummarySwitchPowerHistoryAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		CancellationToken cancellationToken = default);
}
