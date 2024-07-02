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

	/// <summary>
	/// List all devices in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="configurationUpdatedAfter">Filter results by whether or not the device's configuration has been updated after the given timestamp (optional)</param>
	/// <param name="networksIds">Optional parameter to filter devices by network</param>
	/// <param name="productTypes">Optional parameter to filter devices by product type. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, and sensor.</param>
	/// <param name="tags">Optional parameter to filter devices by tags.</param>
	/// <param name="tagsFilterType">Optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return networks which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
	/// <param name="name">Optional parameter to filter devices by name. All returned devices will have a name that contains the search term or is an exact match.</param>
	/// <param name="mac">Optional parameter to filter devices by MAC address. All returned devices will have a MAC address that contains the search term or is an exact match</param>
	/// <param name="serial">Optional parameter to filter devices by serial number. All returned devices will have a serial number that contains the search term or is an exact match</param>
	/// <param name="model">Optional parameter to filter devices by model. All returned devices will have a model that contains the search term or is an exact match</param>
	/// <param name="macs">Optional parameter to filter devices by one or more MAC addresses. All returned devices will have a MAC address that is an exact match</param>
	/// <param name="serials">Optional parameter to filter devices by one or more serial numbers. All returned devices will have a serial number that is an exact match</param>
	/// <param name="sensorMetrics">Optional parameter to filter devices by the metrics that they provide. Only applies to sensor devices</param>
	/// <param name="sensorAlertProfileIds">Optional parameter to filter devices by the alert profiles that are bound to them. Only applies to sensor devices.</param>
	/// <param name="models">Optional parameter to filter devices by one or more models. All returned devices will have a model that is an exact match</param>
	public static Task<List<OrganizationDevice>> GetOrganizationDevicesAllAsync(
		this IOrganizationsDevices organizationDevices,
		string organizationId,
		string configurationUpdatedAfter = null!,
		List<string>? networksIds = null,
		List<string>? productTypes = null,
		List<string>? tags = null,
		string? tagsFilterType = null,
		string? name = null,
		string? mac = null,
		string? serial = null,
		string? model = null,
		List<string>? macs = null,
		List<string>? serials = null,
		List<string>? sensorMetrics = null,
		List<string>? sensorAlertProfileIds = null,
		List<string>? models = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationDevices.GetOrganizationDevicesApiResponseAsync(
						organizationId,
						startingAfter,
						configurationUpdatedAfter,
						networksIds,
						productTypes,
						tags,
						tagsFilterType,
						name,
						mac,
						serial,
						model,
						macs,
						serials,
						sensorMetrics,
						sensorAlertProfileIds,
						models,
						cancellationToken
					),
					cancellationToken
			);
}
