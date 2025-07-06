namespace Meraki.Api.Interfaces.Products.Switch;
public interface ISwitchRoutingStaticRoutes
{
	/// <summary>
	/// List layer 3 static routes for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceSwitchRoutingStaticRoutes")]
	[Get("/devices/{serial}/switch/routing/staticRoutes")]
	Task<List<SwitchStaticRoute>> GetDeviceSwitchRoutingStaticRoutesAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a layer 3 static route for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="staticRouteId">The static route id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceSwitchRoutingStaticRoute")]
	[Get("/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}")]
	Task<SwitchStaticRoute> GetDeviceSwitchRoutingStaticRouteAsync(
		string serial,
		string staticRouteId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a layer 3 static route for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="switchStaticRoute">The switch static route to create</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("createDeviceSwitchRoutingStaticRoute")]
	[Post("/devices/{serial}/switch/routing/staticRoutes")]
	Task<SwitchStaticRoute> CreateDeviceSwitchRoutingStaticRouteAsync(
		string serial,
		[Body] SwitchStaticRoute switchStaticRoute,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a layer 3 static route for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="staticRouteId"></param>
	/// <param name="switchStaticRoute">The switch static route to update</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("updateDeviceSwitchRoutingStaticRoute")]
	[Put("/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}")]
	Task<SwitchStaticRoute> UpdateDeviceSwitchRoutingStaticRouteAsync(
		string serial,
		string staticRouteId,
		[Body] SwitchStaticRoute switchStaticRoute,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a layer 3 static route for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="staticRouteId">The static route id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteDeviceSwitchRoutingStaticRoute")]
	[Delete("/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}")]
	Task DeleteDeviceSwitchRoutingStaticRouteAsync(
		string serial,
		string staticRouteId,
		CancellationToken cancellationToken = default
		);
}
