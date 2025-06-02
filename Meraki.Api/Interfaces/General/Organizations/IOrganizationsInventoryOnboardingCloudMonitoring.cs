namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsInventoryOnboardingCloudMonitoring
{
	/// <summary>
	/// Imports event logs related to the onboarding app into elastisearch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationInventoryOnboardingCloudMonitoringExportEvent")]
	[Post("/organizations/{organizationId}/inventory/onboarding/cloudMonitoring/exportEvents")]
	Task CreateOrganizationInventoryOnboardingCloudMonitoringExportEventAsync(
		string organizationId,
		[Body] OrganizationsInventoryOnboardingCloudMonitoringExportEventCreateRequest request,
		CancellationToken cancellationToken = default);
}
