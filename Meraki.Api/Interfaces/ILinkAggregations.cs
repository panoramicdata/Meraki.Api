using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ILinkAggregations
	{
		/// <summary>
		/// Create a link aggregation group
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkSwitchLinkAggregation">Body for creating a link aggregation group</param>
		[Post("/networks/{networkId}/switch/linkAggregations")]
		Task<SwitchLinkAggregationCreationRequest> CreateNetworkSwitchLinkAggregationAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchLinkAggregationCreationRequest CreateNetworkSwitchLinkAggregation,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Split a link aggregation group into separate ports
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="linkAggregationId">The link aggregation id</param>
		[Delete("/networks/{networkId}/switch/linkAggregations/{linkAggregationId}")]
		Task DeleteNetworkSwitchLinkAggregationAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("linkAggregationId")] string linkAggregationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List link aggregation groups
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/linkAggregations")]
		Task<List<SwitchLinkAggregationCreationRequest>> GetNetworkSwitchLinkAggregationsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a link aggregation group
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="linkAggregationId">The link aggregation id</param>
		/// <param name="UpdateNetworkSwitchLinkAggregation">Body for updating a link aggregation group</param>
		[Put("/networks/{networkId}/switch/linkAggregations/{linkAggregationId}")]
		Task<SwitchLinkAggregationCreationRequest> UpdateNetworkSwitchLinkAggregationAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("linkAggregationId")] string linkAggregationId,
			[Body] SwitchLinkAggregationCreationRequest UpdateNetworkSwitchLinkAggregation,
			CancellationToken cancellationToken = default
			);
	}
}
