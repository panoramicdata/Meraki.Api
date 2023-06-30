namespace Meraki.Api.Extensions;

public static class IOrganizationsDevicesExtensions
{
	/// <summary>
	/// List the status of every Meraki device in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkIds">Optional parameter to filter devices by network ids.</param>
	/// <param name="serials">Optional parameter to filter devices by serials.</param>
	/// <param name="statuses">Optional parameter to filter devices by statuses. Valid statuses are ["online", "alerting", "offline", "dormant"].</param>
	/// <param name="productTypes">An optional parameter to filter device statuses by product type. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, and sensor.</param>
	/// <param name="models">Optional parameter to filter devices by models.</param>
	/// <param name="tags">An optional parameter to filter devices by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
	/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return devices which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
	public static Task<List<OrganizationDeviceStatus>> GetOrganizationDevicesStatusesAllAsync(
		this IOrganizationsDevices organizationDevices,
		string organizationId,
		List<string>? networkIds = null,
		List<string>? serials = null,
		List<string>? statuses = null,
		List<string>? productTypes = null,
		List<string>? models = null,
		List<string>? tags = null,
		string? tagsFilterType = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationDevices.GetDevicesStatusesApiResponseAsync(
						organizationId,
						startingAfter,
						networkIds,
						serials,
						statuses,
						productTypes,
						models,
						tags,
						tagsFilterType,
						cancellationToken
					),
					cancellationToken
			);

	/// <summary>
	/// List the provisioning status of every Meraki device in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkIds">Optional parameter to filter devices by network ids.</param>
	/// <param name="serials">Optional parameter to filter devices by serials.</param>
	/// <param name="status">Optional parameter to filter devices by statuses. Valid statuses are ["online", "alerting", "offline", "dormant"].</param>
	/// <param name="productTypes">An optional parameter to filter device statuses by product type. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, and sensor.</param>
	/// <param name="tags">An optional parameter to filter devices by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
	/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return devices which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
	public static Task<List<DeviceProvisioningStatus>> GetOrganizationDevicesProvisioningStatusesAllAsync(
		this IOrganizationsDevices organizationDevices,
		string organizationId,
		List<string>? networkIds = null,
		List<string>? serials = null,
		string? status = null,
		List<string>? productTypes = null,
		List<string>? tags = null,
		string? tagsFilterType = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationDevices.GetDevicesProvisioningStatusesApiResponseAsync(
						organizationId,
						startingAfter,
						networkIds,
						serials,
						status,
						productTypes,
						tags,
						tagsFilterType,
						cancellationToken
					),
					cancellationToken
			);
}
