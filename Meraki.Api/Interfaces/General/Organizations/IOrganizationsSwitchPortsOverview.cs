namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Organizations Switch Ports Overview
/// </summary>
public interface IOrganizationsSwitchPortsOverview
{
	/// <summary>
	/// Returns the counts of all active ports for the requested timespan, grouped by speed.
	/// An active port is a port that at any point during the timeframe is observed to be connected to a responsive device and isn't configured to be disabled.
	/// For a port that is observed at multiple speeds during the timeframe, it will be counted at the highest speed observed.
	/// The number of inactive ports, and the total number of ports are also provided.
	/// Only ports on switches online during the timeframe will be represented and a port is only guaranteed to be present
	/// if its switch was online for at least 6 hours of the timeframe.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. Maximum = 2678400</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSwitchPortsOverview")]
	[Get("/organizations/{organizationId}/switch/ports/overview")]
	Task<SwitchPortsOverview> GetOrganizationSwitchPortsOverviewAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		CancellationToken cancellationToken = default);
}
