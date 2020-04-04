using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ILinkAggregations
	{
		/// <summary>
		/// createNetworkSwitchLinkAggregation
		/// </summary>
		/// <remarks>
		/// Create a link aggregation group
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSwitchLinkAggregation"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switch/linkAggregations")]
		Task<object> CreateNetworkSwitchLinkAggregation(
			[AliasAs("networkId")]string networkId,
			[Body]CreateNetworkSwitchLinkAggregation createNetworkSwitchLinkAggregation
			);

		/// <summary>
		/// deleteNetworkSwitchLinkAggregation
		/// </summary>
		/// <remarks>
		/// Split a link aggregation group into separate ports
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="linkAggregationId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/switch/linkAggregations/{linkAggregationId}")]
		Task DeleteNetworkSwitchLinkAggregation(
			[AliasAs("networkId")]string networkId,
			[AliasAs("linkAggregationId")]string linkAggregationId
			);

		/// <summary>
		/// getNetworkSwitchLinkAggregations
		/// </summary>
		/// <remarks>
		/// List link aggregation groups
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/linkAggregations")]
		Task<object> GetNetworkSwitchLinkAggregations(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkSwitchLinkAggregation
		/// </summary>
		/// <remarks>
		/// Update a link aggregation group
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="linkAggregationId"></param>
		/// <param name="updateNetworkSwitchLinkAggregation"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/linkAggregations/{linkAggregationId}")]
		Task<object> UpdateNetworkSwitchLinkAggregation(
			[AliasAs("networkId")]string networkId,
			[AliasAs("linkAggregationId")]string linkAggregationId,
			[Body]UpdateNetworkSwitchLinkAggregation updateNetworkSwitchLinkAggregation
			);
	}
}
