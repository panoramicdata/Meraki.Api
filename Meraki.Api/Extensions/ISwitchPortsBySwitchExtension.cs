namespace Meraki.Api.Extensions;

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
