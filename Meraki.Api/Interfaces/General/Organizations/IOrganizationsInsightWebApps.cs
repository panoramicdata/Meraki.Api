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

	/// <summary>
	/// Add a custom web application for Insight to be able to track
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationInsightWebApp")]
	[Post("/organizations/{organizationId}/insight/webApps")]
	Task<OrganizationInsightWebAppSimple> CreateOrganizationInsightWebAppAsync(
		string organizationId,
		[Body] OrganizationInsightWebAppCreateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update a custom web application for Insight to be able to track
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="customCounterSetRuleId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationInsightWebApp")]
	[Put("/organizations/{organizationId}/insight/webApps/{customCounterSetRuleId}")]
	Task<OrganizationInsightWebAppSimple> UpdateOrganizationInsightWebAppAsync(
		string organizationId,
		string customCounterSetRuleId,
		[Body] OrganizationInsightWebAppUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
