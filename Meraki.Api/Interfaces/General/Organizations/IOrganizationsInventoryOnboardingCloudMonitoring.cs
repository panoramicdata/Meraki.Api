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

	/// <summary>
	/// Check the status of a committed Import operation
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationInventoryOnboardingCloudMonitoringImports")]
	[Get("/organizations/{organizationId}/inventory/onboarding/cloudMonitoring/imports")]
	Task<List<OrganizationsInventoryOnboardingCloudMonitoringImport>> GetOrganizationInventoryOnboardingCloudMonitoringImportsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Commits the import operation to complete the onboarding of a device into Dashboard for monitoring.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationInventoryOnboardingCloudMonitoringImport")]
	[Post("/organizations/{organizationId}/inventory/onboarding/cloudMonitoring/imports")]
	Task<List<OrganizationsInventoryOnboardingCloudMonitoringCreateResponseItem>> CreateOrganizationInventoryOnboardingCloudMonitoringImportAsync(
		string organizationId,
		[Body] OrganizationsInventoryOnboardingCloudMonitoringImportCreateRequest request,
		CancellationToken cancellationToken = default);
}
