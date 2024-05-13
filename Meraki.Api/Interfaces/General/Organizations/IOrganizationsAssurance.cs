namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsAssuranceAlerts
{
	/// <summary>
	/// Return all health alerts for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 4 - 300. Default is 30.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="sortOrder">Sorted order of entries. Order options are 'ascending' and 'descending'. Default is 'ascending'.</param>
	/// <param name="network">Optional parameter to filter alerts by network ids.</param>
	/// <param name="severity">Optional parameter to filter by severity type.</param>
	/// <param name="types">Optional parameter to filter by alert type.</param>
	/// <param name="tsStart">Optional parameter to filter by starting timestamp</param>
	/// <param name="tsEnd">Optional parameter to filter by end timestamp</param>
	/// <param name="category">Optional parameter to filter by category.</param>
	/// <param name="sortBy">Optional parameter to set column to sort by.</param>
	/// <param name="serials">Optional parameter to filter by primary device serial</param>
	/// <param name="deviceTypes">Optional parameter to filter by device types</param>
	/// <param name="deviceTags">Optional parameter to filter by device tags</param>
	/// <param name="active">Optional parameter to filter by active alerts defaults to true</param>
	/// <param name="dismissed">Optional parameter to filter by dismissed alerts defaults to false</param>
	/// <param name="resolved">Optional parameter to filter by resolved alerts defaults to false</param>
	/// <param name="suppressAlertsForOfflineNodes">When set to true the api will only return connectivity alerts for a given device if that device is in an offline state. This only applies to devices. This is ignored when resolved is true. Example: If a Switch has a VLan Mismatch and is Unreachable. only the Unreachable alert will be returned. Defaults to false.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationAssuranceAlerts")]
	[Get("/organizations/{organizationId}/assurance/alerts")]
	Task<List<OrganizationAssuranceAlert>> GetOrganizationAssuranceAlertsAsync(
		string organizationId,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		string? sortOrder,
		string? network,
		string? severity,
		[AliasAs("types[]")] List<string>? types,
		string? tsStart,
		string? tsEnd,
		string? category,
		string? sortBy,
		[AliasAs("serials[]")] List<string>? serials,
		[AliasAs("deviceTypes[]")] List<string>? deviceTypes,
		[AliasAs("deviceTags[]")] List<string>? deviceTags,
		bool? active,
		bool? dismissed,
		bool? resolved,
		bool? suppressAlertsForOfflineNodes,
		CancellationToken cancellationToken = default);

	[Get("/organizations/{organizationId}/assurance/alerts")]
	internal Task<ApiResponse<List<OrganizationAssuranceAlert>>> GetOrganizationAssuranceAlertsApiResponseAsync(
		string organizationId,
		string? startingAfter,
		string? sortOrder,
		string? network,
		string? severity,
		[AliasAs("types[]")] List<string>? types,
		string? tsStart,
		string? tsEnd,
		string? category,
		string? sortBy,
		[AliasAs("serials[]")] List<string>? serials,
		[AliasAs("deviceTypes[]")] List<string>? deviceTypes,
		[AliasAs("deviceTags[]")] List<string>? deviceTags,
		bool? active,
		bool? dismissed,
		bool? resolved,
		bool? suppressAlertsForOfflineNodes,
		CancellationToken cancellationToken = default);

}