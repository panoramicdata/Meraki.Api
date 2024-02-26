namespace Meraki.Api.Extensions;

public static class IOrganizationsApiRequestsExtensions
{
	/// <summary>
	/// List the API requests made by an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 31 days. (optional)</param>
	/// <param name="adminId">Filter the results by the ID of the admin who made the API requests (optional)</param>
	/// <param name="path">Filter the results by the path of the API requests (optional)</param>
	/// <param name="method">Filter the results by the method of the API requests (must be 'GET', 'PUT', 'POST' or 'DELETE') (optional)</param>
	/// <param name="responseCode">Filter the results by the response code of the API requests (optional)</param>
	/// <param name="sourceIp">Filter the results by the IP address of the originating API request (optional)</param>
	/// <param name="userAgent">Filter the results by the user agent string of the API request</param>
	/// <param name="version">Filter the results by the API version of the API request</param>
	/// <param name="operationIds">Filter the results by one or more operation IDs for the API request</param>
	public static Task<List<ApiUsage>> GetOrganizationApiRequestsAllAsync(
		this IOrganizationsApiRequests organizationsApiRequests,
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? adminId = null,
		string? path = null,
		string? method = null,
		int? responseCode = null,
		string? sourceIp = null,
		string? userAgent = null,
		int? version = null,
		List<string>? operationIds = null,
		CancellationToken cancellationToken = default)
			=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationsApiRequests.GetOrganizationApiRequestsApiResponseAsync(
					organizationId,
					t0,
					t1,
					timespan,
					startingAfter,
					adminId,
					path,
					method,
					responseCode,
					sourceIp,
					userAgent,
					version,
					operationIds,
					cancellationToken)
				, cancellationToken
				);
}
