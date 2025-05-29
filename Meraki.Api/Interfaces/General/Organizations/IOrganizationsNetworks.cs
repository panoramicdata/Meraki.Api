namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsNetworks
{
	/// <summary>
	/// Get paged networks that the user has privileges on in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">An optional parameter that is the ID of a config template. Will return all networks bound to that template. (optional)</param>
	/// <param name="tags">An optional parameter to filter networks by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
	/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return networks which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
	/// <param name="productTypes">An optional parameter to filter networks by product type. Results will have at least one of the included product types.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 100000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	[Get("/organizations/{organizationId}/networks")]
	Task<List<Network>> GetOrganizationNetworksAsync(
		string organizationId,
		string? configTemplateId = null,
		[AliasAs("tags[]")] List<string>? tags = null,
		string? tagsFilterType = null,
		[AliasAs("productTypes[]")] List<ProductType>? productTypes = null,
		int? perPage = 100000,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default);

	// Used by IOrganizationsNetworksExtensions.GetOrganizationNetworksAllAsync
	[Get("/organizations/{organizationId}/networks")]
	internal Task<ApiResponse<List<Network>>> GetNetworksApiResponseAsync(
		string organizationId,
		string? configTemplateId = null,
		[AliasAs("tags[]")] List<string>? tags = null,
		string? tagsFilterType = null,
		[AliasAs("productTypes[]")] List<ProductType>? productTypes = null,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Combine multiple networks into a single network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API cg</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="combineOrganizationNetworks">Body for combining networks</param>
	[Post("/organizations/{organizationId}/networks/combine")]
	Task<CombineNetworkResponse> CombineOrganizationNetworksAsync(
		string organizationId,
		[Body] CombineOrganizationNetworksRequest combineOrganizationNetworks,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationNetwork">Body for creating a network</param>
	[Post("/organizations/{organizationId}/networks")]
	Task<Network> CreateOrganizationNetworkAsync(
		string organizationId,
		[Body] NetworkCreationRequest createOrganizationNetwork,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Move networks from one organization to another. Note that as this is an Early Access feature it may result in unexpected behavior and is best tested with non-critical networks. For more information and caveats around network move limitations see <a href = "https://documentation.meraki.com/General_Administration/Organizations_and_Networks/Network_Portability">Network Portability</a>
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="networkMoveRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createNetworkMove")]
	[Post("/organizations/{organizationId}/networks/moves")]
	Task<NetworkMove> CreateNetworkMoveAsync(
		string organizationId,
		[Body] NetworkMoveRequest networkMoveRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a list of network move operations in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkMoves")]
	[Get("/organizations/{organizationId}/networks/moves")]
	Task<List<NetworkMoveDetailed>> GetNetworkMovesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return details on the specified network move operation
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="networkMoveId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkMove")]
	[Get("/organizations/{organizationId}/networks/moves/{networkMoveId}")]
	Task<NetworkMoveDetailed> GetNetworkMoveAsync(
		string organizationId,
		string networkMoveId,
		CancellationToken cancellationToken = default);
}
