namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IAppliancePrefixesDelegatedStatics

{
	/// <summary>
	/// List static delegated prefixes for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkAppliancePrefixesDelegatedStatics")]
	[Get("/networks/{networkId}/appliance/prefixes/delegated/statics")]
	Task<List<NetworkAppliancePrefixesDelegatedStatic>> GetNetworkAppliancePrefixesDelegatedStaticsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a static delegated prefix from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="staticDelegatedPrefixId">ID of the static delegate prefix</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkAppliancePrefixesDelegatedStatic")]
	[Get("/networks/{networkId}/appliance/prefixes/delegated/statics/{staticDelegatedPrefixId}")]
	Task<NetworkAppliancePrefixesDelegatedStatic> GetNetworkAppliancePrefixesDelegatedStaticAsync(
		string networkId,
		string staticDelegatedPrefixId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Add a static delegated prefix from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkAppliancePrefixesDelegatedStaticCreateRequest">The body for the create request</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createNetworkAppliancePrefixesDelegatedStatic")]
	[Post("/networks/{networkId}/appliance/prefixes/delegated/statics")]
	Task<NetworkAppliancePrefixesDelegatedStatic> CreateNetworkAppliancePrefixesDelegatedStaticAsync(
		string networkId,
		[Body] NetworkAppliancePrefixesDelegatedStaticCreateRequest networkAppliancePrefixesDelegatedStaticCreateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a static delegated prefix from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="staticDelegatedPrefixId">The static sdelegated prefix id</param>
	/// <param name="networkAppliancePrefixedsDelegatedStaticUpdateRequest">Body for the update request</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkAppliancePrefixesDelegatedStatic")]
	[Put("/networks/{networkId}/appliance/prefixes/delegated/statics/{staticDelegatedPrefixId}")]
	Task<NetworkAppliancePrefixesDelegatedStatic> UpdateNetworkAppliancePrefixesDelegatedStaticAsync(
		string networkId,
		string staticDelegatedPrefixId,
		[Body] NetworkAppliancePrefixesDelegatedStaticUpdateRequest networkAppliancePrefixedsDelegatedStaticUpdateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a static delegated prefix from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="staticDelegatedPrefixId">The static sdelegated prefix id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteNetworkAppliancePrefixesDelegatedStatic")]
	[Delete("/networks/{networkId}/appliance/prefixes/delegated/statics/{staticDelegatedPrefixId}")]
	Task DeleteNetworkAppliancePrefixesDelegatedStaticAsync(
		string networkId,
		string staticDelegatedPrefixId,
		CancellationToken cancellationToken = default);
}
