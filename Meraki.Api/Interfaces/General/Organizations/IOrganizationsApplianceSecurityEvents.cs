namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsApplianceSecurityEvents
{
	/// <summary>
	/// List the security events for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. Data is gathered after the specified t0 value. The maximum lookback period is 365 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 365 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 365 days. The default is 31 days.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100.</param>
	/// <param name="startingBefore">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="sortOrder">Sorted order of security events based on event detection time. Order options are 'ascending' or 'descending'. Default is ascending order.</param>
	[ApiOperationId("getOrganizationApplianceSecurityEvents")]
	[Get("/organizations/{organizationId}/appliance/security/events")]
	Task<List<SecurityEvent>> GetOrganizationApplianceSecurityEventsAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string t0,
		[AliasAs("t1")] string t1,
		[AliasAs("timespan")] int timespan = 31,
		[AliasAs("perPage")] int perPage = 100,
		[AliasAs("startingBefore")] string? startingBefore = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		[AliasAs("sortOrder")] string sortOrder = "ascending",
		CancellationToken cancellationToken = default);
}