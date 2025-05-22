namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsInventoryDevices
{
	/// <summary>
	/// Return the device inventory for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="usedState">Filter results by used or unused inventory. Accepted values are "used" or "unused".</param>
	/// <param name="search">Search for devices in inventory based on serial number, mac address, or model.</param>
	/// <param name="macs">Search for devices in inventory based on mac addresses.</param>
	/// <param name="networkIds">Search for devices in inventory based on network ids.</param>
	/// <param name="serials">Search for devices in inventory based on serials.</param>
	/// <param name="models">Search for devices in inventory based on model.</param>
	/// <param name="tags">An optional parameter to filter devices by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
	/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return devices which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
	/// <param name="productTypes">Optional parameter to filter devices by product type. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, and sensor.</param>
	[Get("/organizations/{organizationId}/inventory/devices")]
	Task<List<InventoryDevice>> GetOrganizationInventoryDevicesAsync(
		string organizationId,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		string? usedState = null,
		string? search = null,
		[AliasAs("macs[]")] List<string>? macs = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		[AliasAs("serials[]")] List<string>? serials = null,
		[AliasAs("models[]")] List<string>? models = null,
		[AliasAs("orderNumbers[]")] List<string>? orderNumbers = null,
		[AliasAs("tags[]")] List<string>? tags = null,
		TagsFilterType? tagsFilterType = null,
		[AliasAs("productTypes[]")] List<ProductType>? productTypes = null,
		CancellationToken cancellationToken = default);

	// Used by IOrganizationsInventoryDevicesExtensions.GetOrganizationInventoryDevicesAllAsync
	[Get("/organizations/{organizationId}/inventory/devices")]
	internal Task<ApiResponse<List<InventoryDevice>>> GetOrganizationInventoryDevicesApiResponseAsync(
		string organizationId,
		string? startingAfter = null,
		string? endingBefore = null,
		string? usedState = null,
		string? search = null,
		[AliasAs("macs[]")] List<string>? macs = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		[AliasAs("serials[]")] List<string>? serials = null,
		[AliasAs("models[]")] List<string>? models = null,
		[AliasAs("orderNumbers[]")] List<string>? orderNumbers = null,
		[AliasAs("tags[]")] List<string>? tags = null,
		TagsFilterType? tagsFilterType = null,
		[AliasAs("productTypes[]")] List<ProductType>? productTypes = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the device inventory for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="serial">The serial number</param>
	[Get("/organizations/{organizationId}/inventory/devices/{serial}")]
	Task<InventoryDevice> GetOrganizationInventoryDeviceAsync(
		string organizationId,
		string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Claim a list of devices, licenses, and/or orders into an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="organizationInventoryClaimRequest">Body for making an inventory claim request</param>
	[Post("/organizations/{organizationId}/inventory/claim")]
	Task<OrganizationInventoryClaimResponse> ClaimIntoOrganizationInventoryAsync(
		string organizationId,
		[Body] OrganizationInventoryClaimRequest organizationInventoryClaimRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Release a list of claimed devices from an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="organizationInventoryReleaseRequest">Body for making an inventory release request</param>
	[Post("/organizations/{organizationId}/inventory/release")]
	Task<OrganizationInventoryReleaseResponse> ReleaseFromOrganizationInventoryAsync(
		string organizationId,
		[Body] OrganizationInventoryReleaseRequest organizationInventoryReleaseRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Swap the devices identified by devices.old with a devices.new, then perform the :afterAction on the devices.old.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationInventoryDevicesSwapsBulk")]
	[Post("/organizations/{organizationId}/inventory/devices/swaps/bulk")]
	Task<OrganizationInventorySwapCreateResponse> CreateOrganizationInventoryDevicesSwapsBulkAsync(
		string organizationId,
		[Body] OrganizationInventorySwapCreateRequest request,
		CancellationToken cancellationToken = default);
}
