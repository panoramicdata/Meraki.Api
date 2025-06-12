namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsInsight
{
	/// <summary>
	/// List the speed tests for the given devices under this organization. Only valid for organizations with Meraki Insight.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationInsightSpeedTestResults")]
	[Get("/organizations/{organizationId}/insight/speedTestResults")]
	Task<List<OrganizationsInsightSpeedTestResult>> GetOrganizationInsightSpeedTestResultsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
