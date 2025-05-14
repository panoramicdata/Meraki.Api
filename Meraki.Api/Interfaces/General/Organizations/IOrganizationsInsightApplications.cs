namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsInsightApplications
{
	/// <summary>
	/// Add an Insight tracked application
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationInsightApplication")]
	[Post("/organizations/{organizationId}/insight/applications")]
	Task<OrganizationInsightApplication> CreateOrganizationInsightApplicationAsync(
		string organizationId,
		[Body] OrganizationInsightApplicationCreateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update an Insight tracked application
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="applicationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationInsightApplication")]
	[Put("/organizations/{organizationId}/insight/applications/{applicationId}")]
	Task<OrganizationInsightApplication> UpdateOrganizationInsightApplicationAsync(
		string organizationId,
		string applicationId,
		[Body] OrganizationInsightApplicationUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
