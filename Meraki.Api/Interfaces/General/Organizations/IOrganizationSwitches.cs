namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// List the switchports in an organization
/// </summary>
public interface IOrganizationSwitches

{
	/// <summary>
	/// List the switchports in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 50. Default is 50</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="networkIds">Optional parameter to filter switchports by network.</param>
	/// <param name="portProfileIds">Optional parameter to filter switchports belonging to the specified port profiles</param>
	/// <param name="name">Optional parameter to filter switchports belonging to switches by name. All returned switches will have a name that contains the search term or is an exact match.</param>
	/// <param name="mac">Optional parameter to filter switchports belonging to switches by MAC address. All returned switches will have a MAC address that contains the search term or is an exact match.</param>
	/// <param name="macs">Optional parameter to filter switchports by one or more MAC addresses belonging to devices. All switchports returned belong to MAC addresses of switches that are an exact match.</param>
	/// <param name="serial">Optional parameter to filter switchports belonging to switches by serial number. All returned switches will have a serial number that contains the search term or is an exact match.</param>
	/// <param name="serials">Optional parameter to filter switchports belonging to switches with one or more serial numbers. All switchports returned belong to serial numbers of switches that are an exact match.</param>
	/// <param name="configurationUpdatedAfter">Optional parameter to filter results by switches where the configuration has been updated after the given timestamp</param>
	[ApiOperationId("getOrganizationSwitchPortsStatusesBySwitch")]
	[Get("/organizations/{organizationId}/switch/ports/statuses/bySwitch")]
	Task<List<SwitchPortsStatusesBySwitch>> GetOrganizationSwitchPortsStatusesBySwitchAsync(
		string organizationId,
		string? t0,
		int? timespan,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		[AliasAs("portProfileIds[]")] List<string>? portProfileIds,
		string? name,
		string? mac,
		[AliasAs("macs[]")] List<string>? macs,
		string? serial,
		[AliasAs("serials[]")] List<string>? serials,
		string? configurationUpdatedAfter,
		CancellationToken cancellationToken = default);

	// Used by GetOrganizationSwitchPortsStatusesBySwitchAllAsync
	[Get("/organizations/{organizationId}/switch/ports/statuses/bySwitch")]
	internal Task<ApiResponse<List<SwitchPortsStatusesBySwitch>>> GetOrganizationSwitchPortsStatusesBySwitchApiResponseAsync(
		string organizationId,
		string? t0,
		int? timespan,
		string? startingAfter,
		string? endingBefore,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		[AliasAs("portProfileIds[]")] List<string>? portProfileIds,
		string? name,
		string? mac,
		[AliasAs("macs[]")] List<string>? macs,
		string? serial,
		[AliasAs("serials[]")] List<string>? serials,
		string? configurationUpdatedAfter,
		CancellationToken cancellationToken = default);

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
		[AliasAs("networkIds[]")] List<string>? networkIds,
		string? name,
		string? mac,
		string serial,
		[AliasAs("serials[]")] List<string>? serials,
		[AliasAs("macs[]")] List<string>? macs,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Used by ISwitchPortsBySwitchExtensions.GetOrgnanizationSwitchPortsBySwitchAsync
	/// </summary>
	[Get("/organizations/{organizationId}/switch/ports/bySwitch")]
	internal Task<ApiResponse<List<SwitchPortsBySwitch>>> GetOrganizationSwitchPortsBySwitchApiResponseAsync(
		string organizationId,
		string? startingAfter,
		string? endingBefore,
		string? configurationUpdatedAfter,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		string? name,
		string? mac,
		string? serial,
		[AliasAs("serials[]")] List<string>? serials,
		[AliasAs("macs[]")] List<string>? macs,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// List the port profiles in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSwitchPortsProfiles")]
	[Get("/organizations/{organizationId}/switch/ports/profiles")]
	Task<List<OrganizationSwitchPortsProfilesProfile>> GetOrganizationSwitchPortsProfilesAsync(string organizationId, CancellationToken cancellationToken = default);

	/// <summary>
	/// Get detailed information about a port profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSwitchPortsProfile")]
	[Get("/organizations/{organizationId}/switch/ports/profiles/{id}")]
	Task<OrganizationSwitchPortsProfilesProfileDetailed> GetOrganizationSwitchPortsProfileAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a port profile in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="organizationSwitchPortsProfilesProfile"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationSwitchPortsProfile")]
	[Put("/organizations/{organizationId}/switch/ports/profiles/{id}")]
	Task<OrganizationSwitchPortsProfilesProfileDetailed> UpdateOrganizationSwitchPortsProfileAsync(
		string organizationId,
		string id,
		[Body] OrganizationSwitchPortsProfilesProfileUpdateRequest organizationSwitchPortsProfilesProfile,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a port profile in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="organizationSwitchPortsProfilesProfile"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSwitchPortsProfile")]
	[Post("/organizations/{organizationId}/switch/ports/profiles")]
	Task<OrganizationSwitchPortsProfilesProfileDetailed> CreateOrganizationSwitchPortsProfilesAsync(
		string organizationId,
		[Body] OrganizationSwitchPortsProfilesProfileCreateRequest organizationSwitchPortsProfilesProfile,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a port profile from an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSwitchPortsProfile")]
	[Delete("/organizations/{organizationId}/switch/ports/profiles/{id}")]
	Task DeleteOrganizationSwitchPortsProfileAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the port profiles in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSwitchPortsProfilesOverviewByProfile")]
	[Get("/organizations/{organizationId}/switch/ports/profiles/overview/byProfile")]
	Task<OrganizationSwitchPortsProfilesOverviewByProfile> GetOrganizationSwitchPortsProfilesOverviewByProfile(string organizationId, CancellationToken cancellationToken);
	/// <summary>
	/// List the historical usage and traffic data of switchports in an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The OrganizationID</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. If interval is provided, the timespan will be autocalculated. maximum = 2678400</param>
	/// <param name="interval">The time interval in seconds for returned data. The valid intervals are: 300, 1200, 14400, 86400. The default is 1200. Interval is calculated if time params are provided.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 50. Default is 50.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="configurationUpdatedAfter">Optional parameter to filter results by switches where the configuration has been updated after the given timestamp</param>
	/// <param name="mac">Optional parameter to filter switchports belonging to switches by MAC address. All returned switches will have a MAC address that contains the search term or is an exact match.</param>
	/// <param name="macs">Optional parameter to filter items to switches that have one of the provided MAC addresses.</param>
	/// <param name="name">Optional parameter to filter items to switches with names that contain the search term or are an exact match.</param>
	/// <param name="networkIds">Optional parameter to filter items to switches in one of the provided networks.</param>
	/// <param name="portProfileIds">Optional parameter to filter items to switches that contain switchports belonging to one of the specified port profiles.</param>
	/// <param name="serial">Optional parameter to filter switchports belonging to switches by serial number. All returned switches will have a serial number that contains the search term or is an exact match.</param>
	/// <param name="serials">Optional parameter to filter switchports belonging to switches with one or more serial numbers. All switchports returned belong to serial numbers of switches that are an exact match.</param>
	[ApiOperationId("getOrganizationSwitchPortsUsageHistoryByDeviceByInterval")]
	[Get("/organizations/{organizationId}/switch/ports/usage/history/byDevice/byInterval")]
	Task<SwitchPortsUsageHistoryByDeviceByInterval> GetOrganizationSwitchPortsUsageHistoryByDeviceByIntervalAsync(
		string organizationId,
		string? t0,
		string? t1,
		int? timespan,
		int? interval,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		string? configurationUpdatedAfter,
		string? mac,
		[AliasAs("macs[]")] List<string>? macs,
		string? name,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		[AliasAs("portProfileIds[]")] List<string>? portProfileIds,
		string? serial,
		[AliasAs("serials[]")] List<string>? serials,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List most recently seen LLDP/CDP discovery and topology information per switch port in an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The OrganizationID</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 20. Default is 10.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="configurationUpdatedAfter">Optional parameter to filter results by switches where the configuration has been updated after the given timestamp</param>
	/// <param name="mac">Optional parameter to filter switchports belonging to switches by MAC address. All returned switches will have a MAC address that contains the search term or is an exact match.</param>
	/// <param name="macs">Optional parameter to filter items to switches that have one of the provided MAC addresses.</param>
	/// <param name="name">Optional parameter to filter items to switches with names that contain the search term or are an exact match.</param>
	/// <param name="networkIds">Optional parameter to filter items to switches in one of the provided networks.</param>
	/// <param name="portProfileIds">Optional parameter to filter items to switches that contain switchports belonging to one of the specified port profiles.</param>
	/// <param name="serial">Optional parameter to filter switchports belonging to switches by serial number. All returned switches will have a serial number that contains the search term or is an exact match.</param>
	/// <param name="serials">Optional parameter to filter switchports belonging to switches with one or more serial numbers. All switchports returned belong to serial numbers of switches that are an exact match.</param>
	[ApiOperationId("getOrganizationSwitchPortsTopologyDiscoveryByDevice")]
	[Get("/organizations/{organizationId}/switch/ports/usage/history/byDevice/byInterval")]
	Task<SwitchPortsTopologyDiscoveryByDevice> GetOrganizationSwitchPortsTopologyDiscoveryByDeviceAsync(
		string organizationId,
		string? t0,
		string? t1,
		int? timespan,
		int? interval,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		string? configurationUpdatedAfter,
		string? mac,
		[AliasAs("macs[]")] List<string>? macs,
		string? name,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		[AliasAs("portProfileIds[]")] List<string>? portProfileIds,
		string? serial,
		[AliasAs("serials[]")] List<string>? serials,
		CancellationToken cancellationToken = default
		);
}
