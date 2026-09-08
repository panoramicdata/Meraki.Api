namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for switch ports by switch
/// </summary>
public static class ISwitchPortsBySwitchExtensions
{
	/// <summary>
	/// Get All Switchports in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="switchPortsBySwitch"></param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configurationUpdatedAfter">Optional parameter to filter results by switches where the configuration has been updated after the given timestamp</param>
	/// <param name="networkIds">Optional parameter to filter switchports by network.</param>
	/// <param name="name">Optional parameter to filter switchports belonging to switches by name. All returned switches will have a name that contains the search term or is an exact match.</param>
	/// <param name="mac">Optional parameter to filter switchports belonging to switches by MAC address. All returned switches will have a MAC address that contains the search term or is an exact match.</param>
	/// <param name="serial">Optional parameter to filter switchports belonging to switches by serial number. All returned switches will have a serial number that contains the search term or is an exact match.</param>
	/// <param name="serials">Optional parameter to filter switchports belonging to switches with one or more serial numbers. All switchports returned belong to serial numbers of switches that are an exact match.</param>
	/// <param name="macs">Optional parameter to filter switchports by one or more MAC addresses belonging to devices. All switchports returned belong to MAC addresses of switches that are an exact match.</param>
	/// <param name="cancellationToken"></param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<SwitchPortsBySwitch>> GetOrganizationSwitchPortsBySwitchAllAsync(
		this IOrganizationSwitches switchPortsBySwitch,
		string organizationId,
		string? configurationUpdatedAfter = null,
		List<string>? networkIds = null,
		string? name = null,
		string? mac = null,
		string? serial = null,
		List<string>? serials = null,
		List<string>? macs = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> switchPortsBySwitch.GetOrganizationSwitchPortsBySwitchApiResponseAsync(
						organizationId,
						startingAfter,
						endingBefore,
						configurationUpdatedAfter,
						networkIds,
						name,
						mac,
						serial,
						serials,
						macs,
						cancellationToken
					),
					cancellationToken
			);
}
