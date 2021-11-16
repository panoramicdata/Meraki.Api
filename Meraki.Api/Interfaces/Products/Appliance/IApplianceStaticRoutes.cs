namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceStaticRoutes
{
	/// <summary>
	/// Return a static route for an MX or teleworker network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="staticRouteId">The static route id</param>
	[ApiOperationId("getNetworkApplianceStaticRoute")]
	[Get("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
	Task<StaticRoute> GetNetworkApplianceStaticRouteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("staticRouteId")] string staticRouteId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the static routes for an MX or teleworker network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceStaticRoutes")]
	[Get("/networks/{networkId}/appliance/staticRoutes")]
	Task<List<StaticRoute>> GetNetworkApplianceStaticRoutesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a static route for an MX or teleworker network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkStaticRoute">Body for adding a static route</param>
	[ApiOperationId("createNetworkApplianceStaticRoute")]
	[Post("/networks/{networkId}/appliance/staticRoutes")]
	Task<StaticRoute> CreateNetworkApplianceStaticRouteAsync(
		[AliasAs("networkId")] string networkId,
		[Body] StaticRouteCreationRequest createNetworkStaticRoute,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a static route for an MX or teleworker network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="staticRouteId">The static route id</param>
	/// <param name="updateNetworkStaticRoute">Body for updating a static route</param>
	[ApiOperationId("updateNetworkApplianceStaticRoute")]
	[Put("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
	Task<StaticRoute> UpdateNetworkApplianceStaticRouteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("staticRouteId")] string staticRouteId,
		[Body] StaticRouteUpdateRequest updateNetworkStaticRoute,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a static route from an MX or teleworker network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="staticRouteId">The static route id</param>
	[ApiOperationId("deleteNetworkApplianceStaticRoute")]
	[Delete("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
	Task DeleteNetworkApplianceStaticRouteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("staticRouteId")] string staticRouteId,
		CancellationToken cancellationToken = default
		);
}
