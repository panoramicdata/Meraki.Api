namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessRfProfiles
{
	/// <summary>
	/// Creates new RF profile for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkWirelessRfProfile">Body for creating an RF profile</param>
	[Post("/networks/{networkId}/wireless/rfProfiles")]
	Task<WirelessRfProfile> CreateNetworkWirelessRfProfileAsync(
		string networkId,
		[Body] WirelessRfProfileCreateUpdateRequest createNetworkWirelessRfProfile,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a RF Profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">The RF profile id</param>
	[Delete("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
	Task DeleteNetworkWirelessRfProfileAsync(
		string networkId,
		string rfProfileId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a RF profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">The RF profile id</param>
	[Get("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
	Task<WirelessRfProfile> GetNetworkWirelessRfProfileAsync(
		string networkId,
		string rfProfileId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the non-basic RF profiles for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="includeTemplateProfiles">If the network is bound to a template, this parameter controls whether or not the non-basic RF profiles defined on the template     should be included in the response alongside the non-basic profiles defined on the bound network. Defaults to false.  (optional)</param>
	[Get("/networks/{networkId}/wireless/rfProfiles")]
	Task<List<WirelessRfProfile>> GetNetworkWirelessRfProfilesAsync(
		string networkId,
		bool? includeTemplateProfiles = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates specified RF profile for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">The RF profile id</param>
	/// <param name="updateNetworkWirelessRfProfile">Body for updating a specified RF profile</param>
	[Put("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
	Task<WirelessRfProfile> UpdateNetworkWirelessRfProfileAsync(
		string networkId,
		string rfProfileId,
		[Body] WirelessRfProfileCreateUpdateRequest updateNetworkWirelessRfProfile,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the non-basic RF profiles for this network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call.</exception>
	/// <param name="organizationId">Organization ID.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="networkIds">Optional parameter to filter devices by network.</param>
	/// <param name="productTypes">Optional parameter to filter devices by product type. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, and sensor.</param>
	/// <param name="name">Optional parameter to filter RF profiles by device name. All returned devices will have a name that contains the search term or is an exact match.</param>
	/// <param name="mac">Optional parameter to filter RF profiles by device MAC address. All returned devices will have a MAC address that contains the search term or is an exact match.</param>
	/// <param name="serial">Optional parameter to filter RF profiles by device serial number. All returned devices will have a serial number that contains the search term or is an exact match.</param>
	/// <param name="model">Optional parameter to filter RF profiles by device model. All returned devices will have a model that contains the search term or is an exact match.</param>
	/// <param name="macs">Optional parameter to filter RF profiles by one or more device MAC addresses. All returned devices will have a MAC address that is an exact match.</param>
	/// <param name="serials">Optional parameter to filter RF profiles by one or more device serial numbers. All returned devices will have a serial number that is an exact match.</param>
	/// <param name="models">Optional parameter to filter RF profiles by one or more device models. All returned devices will have a model that is an exact match.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	[ApiOperationId("getOrganizationWirelessRfProfilesAssignmentsByDevice")]
	[Get("/organizations/{organizationId}/wireless/rfProfiles/assignments/byDevice")]
	Task<List<RfProfilesByDevice>> GetOrganizationWirelessRfProfilesAssignmentsByDeviceAsync(
		string organizationId,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		[AliasAs("productTypes[]")] List<ProductType> productTypes,
		string? name,
		string? mac,
		string? serial,
		string? model,
		[AliasAs("macs[]")] List<string>? macs,
		[AliasAs("serials[]")] List<string>? serials,
		[AliasAs("models[]")] List<string>? models,
		CancellationToken cancellationToken = default
		);

	[Get("/organizations/{organizationId}/wireless/rfProfiles/assignments/byDevice")]
	internal Task<ApiResponse<List<RfProfilesByDevice>>> GetOrganizationWirelessRfProfilesAssignmentsByDeviceApiResponseAsync(
		string organizationId,
		string? startingAfter,
		string? endingBefore,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		[AliasAs("productTypes[]")] List<ProductType> productTypes,
		string? name,
		string? mac,
		string? serial,
		string? model,
		[AliasAs("macs[]")] List<string>? macs,
		[AliasAs("serials[]")] List<string>? serials,
		[AliasAs("models[]")] List<string>? models,
		CancellationToken cancellationToken = default
		);
}
