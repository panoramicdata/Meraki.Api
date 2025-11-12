namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Inventory Onboarding Cloud Monitoring
/// </summary>
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

	/// <summary>
	/// Returns list of networks eligible for adding cloud monitored device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationInventoryOnboardingCloudMonitoringNetworks")]
	[Get("/organizations/{organizationId}/inventory/onboarding/cloudMonitoring/networks")]
	Task<OrganizationInventoryOnboardingCloudMonitoringNetworks> GetOrganizationInventoryOnboardingCloudMonitoringNetworksAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Initiates or updates an import session. An import ID will be generated and used when you are ready to commit the import.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationInventoryOnboardingCloudMonitoringPrepare")]
	[Post("/organizations/{organizationId}/inventory/onboarding/cloudMonitoring/prepare")]
	Task<List<OrganizationInventoryOnboardingCloudMonitoringPrepareItem>> CreateOrganizationInventoryOnboardingCloudMonitoringPrepareAsync(
		string organizationId,
		[Body] OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequest request,
		CancellationToken cancellationToken = default);
}
