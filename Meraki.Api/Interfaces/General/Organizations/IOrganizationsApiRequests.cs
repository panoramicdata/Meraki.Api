namespace Meraki.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsApiRequests
{
	/// <summary>
	/// List the API requests made by an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 31 days. (optional)</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 50. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="adminId">Filter the results by the ID of the admin who made the API requests (optional)</param>
	/// <param name="path">Filter the results by the path of the API requests (optional)</param>
	/// <param name="method">Filter the results by the method of the API requests (must be 'GET', 'PUT', 'POST' or 'DELETE') (optional)</param>
	/// <param name="responseCode">Filter the results by the response code of the API requests (optional)</param>
	/// <param name="sourceIp">Filter the results by the IP address of the originating API request (optional)</param>
	/// <param name="userAgent">Filter the results by the user agent string of the API request</param>
	/// <param name="version">Filter the results by the API version of the API request</param>
	/// <param name="operationIds">Filter the results by one or more operation IDs for the API request</param>
	[Get("/organizations/{organizationId}/apiRequests")]
	Task<List<ApiUsage>> GetOrganizationApiRequestsAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("perPage")] int? perPage = 1000,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		[AliasAs("adminId")] string? adminId = null,
		[AliasAs("path")] string? path = null,
		[AliasAs("method")] string? method = null,
		[AliasAs("responseCode")] int? responseCode = null,
		[AliasAs("sourceIp")] string? sourceIp = null,
		[AliasAs("userAgent")] string? userAgent = null,
		[AliasAs("version")] int? version = null,
		[AliasAs("operationIds")] List<string>? operationIds = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the API requests made by an organization - This endpooint used internally for the Get All call
	/// </summary>
	[Get("/organizations/{organizationId}/apiRequests")]
	internal Task<ApiResponse<List<ApiUsage>>> GetOrganizationApiRequestsApiResponseAsync(
	[AliasAs("organizationId")] string organizationId,
	[AliasAs("t0")] string? t0 = null,
	[AliasAs("t1")] string? t1 = null,
	[AliasAs("timespan")] double? timespan = null,
	[AliasAs("startingAfter")] string? startingAfter = null,
	[AliasAs("adminId")] string? adminId = null,
	[AliasAs("path")] string? path = null,
	[AliasAs("method")] string? method = null,
	[AliasAs("responseCode")] int? responseCode = null,
	[AliasAs("sourceIp")] string? sourceIp = null,
	[AliasAs("userAgent")] string? userAgent = null,
	[AliasAs("version")] int? version = null,
	[AliasAs("operationIds")] List<string>? operationIds = null,
	CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an aggregated overview of API requests data
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 31 days. (optional)</param>
	[Get("/organizations/{organizationId}/apiRequests/overview")]
	Task<ApiUsageOverview> GetOrganizationApiRequestsOverviewAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("t1")] string t1 = null!,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Tracks organizations' API requests by response code across a given time period
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 31 days. (optional)</param>
	/// <param name="interval">The time interval in seconds for returned data. The valid intervals are: 120, 3600, 14400, 21600. The default is 21600. Interval is calculated if time params are provided.</param>
	/// <param name="version">Filter by API version of the endpoint. Allowable values are: [0, 1]</param>
	/// <param name="operationIds">Filter by operation ID of the endpoint</param>
	/// <param name="sourceIps">Filter by source IP that made the API request</param>
	/// <param name="adminIds">Filter by admin ID of user that made the API request</param>
	/// <param name="userAgent">Filter by user agent string for API request. This will filter by a complete or partial match.</param>
	[Get("/organizations/{organizationId}/apiRequests/overview/responseCodes/byInterval")]
	Task<List<ApiRequestsOverview>> GetOrganizationApiRequestsOverviewResponseCodesByIntervalAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("interval")] int? interval = null,
		[AliasAs("version")] int? version = null,
		[AliasAs("operationIds")] List<string>? operationIds = null,
		[AliasAs("sourceIps")] List<string>? sourceIps = null,
		[AliasAs("adminIds")] List<string>? adminIds = null,
		[AliasAs("userAgent")] List<string>? userAgent = null,
		CancellationToken cancellationToken = default);
}
