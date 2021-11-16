namespace Meraki.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsConfigurationChanges
{
	/// <summary>
	/// Get paged Change Log Entries for your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 365 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 365 days. The default is 365 days. (optional)</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 5000. Default is 5000. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="networkId">Filters on the given network (optional)</param>
	/// <param name="adminId">Filters on the given Admin (optional)</param>
	[Get("/organizations/{organizationId}/configurationChanges")]
	Task<List<ChangeLogEntry>> GetOrganizationConfigurationChangesAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("perPage")] int? perPage = 5000,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		[AliasAs("networkId")] string? networkId = null,
		[AliasAs("adminId")] string? adminId = null,
		CancellationToken cancellationToken = default);

	[Get("/organizations/{organizationId}/configurationChanges")]
	internal Task<ApiResponse<List<ChangeLogEntry>>> GetOrganizationConfigurationChangesApiResponseAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string? t0 = null,
		[AliasAs("t1")] string? t1 = null,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("networkId")] string? networkId = null,
		[AliasAs("adminId")] string? adminId = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all Change Log Entries for your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 365 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 365 days. The default is 365 days. (optional)</param>
	/// <param name="networkId">Filters on the given network (optional)</param>
	/// <param name="adminId">Filters on the given Admin (optional)</param>
	Task<List<ChangeLogEntry>> GetOrganizationConfigurationChangesAllAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? networkId = null,
		string? adminId = null,
		CancellationToken cancellationToken = default)
			=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> GetOrganizationConfigurationChangesApiResponseAsync(
					organizationId,
					t0,
					t1,
					timespan,
					startingAfter,
					networkId,
					adminId,
					cancellationToken)
				, cancellationToken
				);
}
