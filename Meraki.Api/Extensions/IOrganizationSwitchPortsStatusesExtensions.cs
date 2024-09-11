namespace Meraki.Api.Extensions;

public static class IOrganizationSwitchPortsStatusesExtensions
{
	/// <summary>
	/// List the switchports in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="networkIds">Optional parameter to filter switchports by network.</param>
	/// <param name="portProfileIds">Optional parameter to filter switchports belonging to the specified port profiles</param>
	/// <param name="name">Optional parameter to filter switchports belonging to switches by name. All returned switches will have a name that contains the search term or is an exact match.</param>
	/// <param name="mac">Optional parameter to filter switchports belonging to switches by MAC address. All returned switches will have a MAC address that contains the search term or is an exact match.</param>
	/// <param name="macs">Optional parameter to filter switchports by one or more MAC addresses belonging to devices. All switchports returned belong to MAC addresses of switches that are an exact match.</param>
	/// <param name="serial">Optional parameter to filter switchports belonging to switches by serial number. All returned switches will have a serial number that contains the search term or is an exact match.</param>
	/// <param name="serials">Optional parameter to filter switchports belonging to switches with one or more serial numbers. All switchports returned belong to serial numbers of switches that are an exact match.</param>
	/// <param name="configurationUpdatedAfter">Optional parameter to filter results by switches where the configuration has been updated after the given timestamp</param>
	public static Task<List<SwitchPortsStatusesBySwitch>> GetOrganizationSwitchPortsStatusesBySwitchAllAsync(
		this IOrganizationSwitches organizationSwitchPortsStatusesBySwitch,
		string organizationId,
		string? t0,
		int? timespan,
		List<string>? networkIds,
		List<string>? portProfileIds,
		string? name,
		string? mac,
		List<string>? macs,
		string? serial,
		List<string>? serials,
		string? configurationUpdatedAfter,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> organizationSwitchPortsStatusesBySwitch.GetOrganizationSwitchPortsStatusesBySwitchApiResponseAsync(
						organizationId,
						t0,
						timespan,
						startingAfter,
						endingBefore,
						networkIds,
						portProfileIds,
						name,
						mac,
						macs,
						serial,
						serials,
						configurationUpdatedAfter,
						cancellationToken
					),
					cancellationToken
			);
}
