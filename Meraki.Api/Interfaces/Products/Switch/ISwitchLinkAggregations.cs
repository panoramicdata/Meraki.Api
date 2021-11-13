namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchLinkAggregations
{
	/// <summary>
	/// List link aggregation groups
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchLinkAggregations")]
	[Get("/networks/{networkId}/switch/linkAggregations")]
	Task<List<SwitchLinkAggregation>> GetNetworkSwitchLinkAggregationsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a link aggregation group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSwitchLinkAggregation">Body for creating a link aggregation group</param>
	[ApiOperationId("createNetworkSwitchLinkAggregation")]
	[Post("/networks/{networkId}/switch/linkAggregations")]
	Task<SwitchLinkAggregation> CreateNetworkSwitchLinkAggregationAsync(
		[AliasAs("networkId")] string networkId,
		[Body] SwitchLinkAggregation createNetworkSwitchLinkAggregation,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Split a link aggregation group into separate ports
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="linkAggregationId">The link aggregation id</param>
	[ApiOperationId("deleteNetworkSwitchLinkAggregation")]
	[Delete("/networks/{networkId}/switch/linkAggregations/{linkAggregationId}")]
	Task DeleteNetworkSwitchLinkAggregationAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("linkAggregationId")] string linkAggregationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a link aggregation group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="linkAggregationId">The link aggregation id</param>
	/// <param name="updateNetworkSwitchLinkAggregation">Body for updating a link aggregation group</param>
	[ApiOperationId("updateNetworkSwitchLinkAggregation")]
	[Put("/networks/{networkId}/switch/linkAggregations/{linkAggregationId}")]
	Task<SwitchLinkAggregation> UpdateNetworkSwitchLinkAggregationAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("linkAggregationId")] string linkAggregationId,
		[Body] SwitchLinkAggregation updateNetworkSwitchLinkAggregation,
		CancellationToken cancellationToken = default
		);
}
