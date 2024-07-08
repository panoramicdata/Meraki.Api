namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationBandwidthUsageHistory
{
	/// <summary>
	/// Return data usage (in megabits per second) over time for all clients in the given organization within a given time range.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="networkTag">Match result to an exact network tag</param>
	/// <param name="deviceTag">Match result to an exact device tag</param>
	/// <param name="networkId">Match result to an exact network id</param>
	/// <param name="ssidName">Filter results by ssid name</param>
	/// <param name="usageUplink">Filter results by usage uplink</param>
	[ApiOperationId("getOrganizationClientsBandwidthUsageHistory")]
	[Get("/organizations/{organizationId}/clients/bandwidthUsageHistory")]
	Task<List<BandwidthUsageHistory>> GetOrganizationClientsBandwidthUsageHistoryAsync(
		string organizationId,
		string t0,
		string t1,
		int timespan = 1,
		string? networkTag = null,
		string? deviceTag = null,
		string? networkId = null,
		string? ssidName = null,
		string? usageUplink = null,
		CancellationToken cancellationToken = default);
}
