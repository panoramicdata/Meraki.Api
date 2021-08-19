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
	public interface IFloorplans
	{
		/// <summary>
		/// Upload a floor plan
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkFloorPlan">Body for uploading a network floor plan</param>
		[Post("/networks/{networkId}/floorPlans")]
		Task<FloorPlan> CreateNetworkFloorPlanAsync(
			[AliasAs("networkId")] string networkId,
			[Body] FloorPlanCreationRequest CreateNetworkFloorPlan,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Destroy a floor plan
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="floorPlanId">The floor plan id</param>
		[Delete("/networks/{networkId}/floorPlans/{floorPlanId}")]
		Task DeleteNetworkFloorPlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("floorPlanId")] string floorPlanId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Find a floor plan by ID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="floorPlanId">The floor plan id</param>
		[Get("/networks/{networkId}/floorPlans/{floorPlanId}")]
		Task<FloorPlan> GetNetworkFloorPlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("floorPlanId")] string floorPlanId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the floor plans that belong to your network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/floorPlans")]
		Task<List<FloorPlan>> GetNetworkFloorPlansAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a floor plan&#39;s geolocation and other meta data
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="floorPlanId">The floor plan id</param>
		/// <param name="UpdateNetworkFloorPlan">Body for updating a network floor plan</param>
		[Put("/networks/{networkId}/floorPlans/{floorPlanId}")]
		Task<FloorPlan> UpdateNetworkFloorPlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("floorPlanId")] string floorPlanId,
			[Body] FloorPlanUpdateRequest UpdateNetworkFloorPlan,
			CancellationToken cancellationToken = default);
	}
}
