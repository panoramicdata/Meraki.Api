namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Fetch all switchports in an organization
/// </summary>
public interface ISwitchPortsBySwitch
{
	/// <summary>
	/// List the switchports in an organization by switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The OrganizationID</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 50. Default is 50.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="configurationUpdatedAfter">Optional parameter to filter results by switches where the configuration has been updated after the given timestamp</param>
	/// <param name="networkIds">Optional parameter to filter switchports by network.</param>
	/// <param name="name">Optional parameter to filter switchports belonging to switches by name. All returned switches will have a name that contains the search term or is an exact match.</param>
	/// <param name="mac">Optional parameter to filter switchports belonging to switches by MAC address. All returned switches will have a MAC address that contains the search term or is an exact match.</param>
	/// <param name="serial">Optional parameter to filter switchports belonging to switches by serial number. All returned switches will have a serial number that contains the search term or is an exact match.</param>
	/// <param name="serials">Optional parameter to filter switchports belonging to switches with one or more serial numbers. All switchports returned belong to serial numbers of switches that are an exact match.</param>
	/// <param name="macs">Optional parameter to filter switchports by one or more MAC addresses belonging to devices. All switchports returned belong to MAC addresses of switches that are an exact match.</param>
	[Get("/organizations/{organizationId}/switch/ports/bySwitch")]
	Task<List<SwitchPortsBySwitch>> GetOrganizationSwitchPortsBySwitchAsync(
		string organizationId,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		string? configurationUpdatedAfter,
		List<string>? networkIds,
		string? name,
		string? mac,
		string serial,
		List<string>? serials,
		List<string>? macs,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Used by ISwitchPortsBySwitchExtensions.GetOrgnanizationSwitchPortsBySwitchAsync
	/// </summary>
	[Get("/organizations/{organizationId}/switch/ports/bySwitch")]
	internal Task<ApiResponse<List<SwitchPortsBySwitch>>> GetOrganizationSwitchPortsBySwitchApiResponseAsync(
		string organizationId,
		string? startingAfter,
		string? configurationUpdatedAfter,
		List<string>? networkIds,
		string? name,
		string? mac,
		string? serial,
		List<string>? serials,
		List<string>? macs,
		CancellationToken cancellationToken = default
	);
}
