namespace Meraki.Api.Interfaces.Products.Switch;
public interface ISwitchRoutingStaticRoutes
{
	/// <summary>
	/// List layer 3 static routes for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[ApiOperationId("getDeviceSwitchRoutingStaticRoutes")]
	[Get("/devices/{serial}/switch/routing/staticRoutes")]
	Task<List<SwitchStaticRoute>> GetStaticRoutesAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a layer 3 static route for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="staticRouteId">The static route id</param>
	[ApiOperationId("getDeviceSwitchRoutingStaticRoute")]
	[Get("/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}")]
	Task<SwitchStaticRoute> GetStaticRouteAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("staticRouteId")] string staticRouteId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a layer 3 static route for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="switchStaticRoute">The switch static route to create</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createDeviceSwitchRoutingStaticRoute")]
	[Post("/devices/{serial}/switch/routing/staticRoutes")]
	Task<SwitchStaticRoute> CreateStaticRouteAsync(
		[AliasAs("serial")] string serial,
		[Body] SwitchStaticRoute switchStaticRoute,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a layer 3 static route for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="switchStaticRoute">The switch static route to update</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDeviceSwitchRoutingStaticRoute")]
	[Put("/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}")]
	Task<SwitchStaticRoute> UpdateStaticRouteAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("staticRouteId")] string staticRouteId,
		[Body] SwitchStaticRoute switchStaticRoute,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a layer 3 static route for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="staticRouteId">The static route id</param>
	[ApiOperationId("deleteDeviceSwitchRoutingStaticRoute")]
	[Delete("/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}")]
	Task DeleteStaticRouteAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("staticRouteId")] string staticRouteId,
		CancellationToken cancellationToken = default
		);
}
