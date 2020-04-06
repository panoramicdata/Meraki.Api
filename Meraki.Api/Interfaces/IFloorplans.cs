using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IFloorplans
	{
		/// <summary>
		/// createNetworkFloorPlan
		/// </summary>
		/// <remarks>
		/// Upload a floor plan
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkFloorPlan"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/floorPlans")]
		Task<object> CreateNetworkFloorPlan(
			[AliasAs("networkId")]string networkId,
			[Body]FloorPlanCreationRequest createNetworkFloorPlan
			);

		/// <summary>
		/// deleteNetworkFloorPlan
		/// </summary>
		/// <remarks>
		/// Destroy a floor plan
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="floorPlanId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/floorPlans/{floorPlanId}")]
		Task DeleteNetworkFloorPlan(
			[AliasAs("networkId")]string networkId,
			[AliasAs("floorPlanId")]string floorPlanId
			);

		/// <summary>
		/// getNetworkFloorPlan
		/// </summary>
		/// <remarks>
		/// Find a floor plan by ID
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="floorPlanId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/floorPlans/{floorPlanId}")]
		Task<object> GetNetworkFloorPlan(
			[AliasAs("networkId")]string networkId,
			[AliasAs("floorPlanId")]string floorPlanId
			);

		/// <summary>
		/// getNetworkFloorPlans
		/// </summary>
		/// <remarks>
		/// List the floor plans that belong to your network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/floorPlans")]
		Task<object> GetNetworkFloorPlans(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkFloorPlan
		/// </summary>
		/// <remarks>
		/// Update a floor plan&#39;s geolocation and other meta data
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="floorPlanId"></param>
		/// <param name="updateNetworkFloorPlan"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/floorPlans/{floorPlanId}")]
		Task<object> UpdateNetworkFloorPlan(
			[AliasAs("networkId")]string networkId,
			[AliasAs("floorPlanId")]string floorPlanId,
			[Body]FloorPlanUpdateRequest updateNetworkFloorPlan);
	}
}
