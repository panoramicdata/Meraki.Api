namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksFloorplans
{
	/// <summary>
	/// List the floor plans that belong to your network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkFloorPlans")]
	[Get("/networks/{networkId}/floorPlans")]
	Task<List<FloorPlan>> GetNetworkFloorPlansAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Upload a floor plan
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkFloorPlan">Body for uploading a network floor plan</param>
	[ApiOperationId("createNetworkFloorPlan")]
	[Post("/networks/{networkId}/floorPlans")]
	Task<FloorPlan> CreateNetworkFloorPlanAsync(
		string networkId,
		[Body] FloorPlanCreationRequest createNetworkFloorPlan,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Find a floor plan by ID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="floorPlanId">The floor plan id</param>
	[ApiOperationId("getNetworkFloorPlan")]
	[Get("/networks/{networkId}/floorPlans/{floorPlanId}")]
	Task<FloorPlan> GetNetworkFloorPlanAsync(
		string networkId,
		string floorPlanId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a floor plan's geolocation and other meta data
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="floorPlanId">The floor plan id</param>
	/// <param name="updateNetworkFloorPlan">Body for updating a network floor plan</param>
	[ApiOperationId("updateNetworkFloorPlan")]
	[Put("/networks/{networkId}/floorPlans/{floorPlanId}")]
	Task<FloorPlan> UpdateNetworkFloorPlanAsync(
		string networkId,
		string floorPlanId,
		[Body] FloorPlanUpdateRequest updateNetworkFloorPlan,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Destroy a floor plan
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="floorPlanId">The floor plan id</param>
	[ApiOperationId("deleteNetworkFloorPlan")]
	[Delete("/networks/{networkId}/floorPlans/{floorPlanId}")]
	Task DeleteNetworkFloorPlanAsync(
		string networkId,
		string floorPlanId,
		CancellationToken cancellationToken = default
		);
}
