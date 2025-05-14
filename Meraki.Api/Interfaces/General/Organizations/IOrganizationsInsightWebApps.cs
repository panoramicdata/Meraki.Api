namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsInsightWebApps
{
	/// <summary>
	/// Lists all default web applications rules with counter set rule ids
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationInsightWebApps")]
	[Get("/organizations/{organizationId}/insight/webApps")]
	Task<List<OrganizationInsightWebApp>> GetOrganizationInsightWebAppsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
