using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxStaticRoutes
	{
		/// <summary>
		/// createNetworkStaticRoute
		/// </summary>
		/// <remarks>
		/// Add a static route for an MX or teleworker network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkStaticRoute"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/staticRoutes")]
		Task<object> CreateNetworkStaticRoute(
			[AliasAs("networkId")]string networkId,
			[Body]StaticRouteCreationRequest createNetworkStaticRoute
			);

		/// <summary>
		/// deleteNetworkStaticRoute
		/// </summary>
		/// <remarks>
		/// Delete a static route from an MX or teleworker network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="staticRouteId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/staticRoutes/{staticRouteId}")]
		Task DeleteNetworkStaticRoute(
			[AliasAs("networkId")]string networkId,
			[AliasAs("staticRouteId")]string staticRouteId
			);

		/// <summary>
		/// getNetworkStaticRoute
		/// </summary>
		/// <remarks>
		/// Return a static route for an MX or teleworker network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="staticRouteId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/staticRoutes/{staticRouteId}")]
		Task<object> GetNetworkStaticRoute(
			[AliasAs("networkId")]string networkId,
			[AliasAs("staticRouteId")]string staticRouteId
			);

		/// <summary>
		/// getNetworkStaticRoutes
		/// </summary>
		/// <remarks>
		/// List the static routes for an MX or teleworker network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/staticRoutes")]
		Task<object> GetNetworkStaticRoutes(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkStaticRoute
		/// </summary>
		/// <remarks>
		/// Update a static route for an MX or teleworker network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="staticRouteId"></param>
		/// <param name="updateNetworkStaticRoute"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/staticRoutes/{staticRouteId}")]
		Task<object> UpdateNetworkStaticRoute(
			[AliasAs("networkId")]string networkId,
			[AliasAs("staticRouteId")]string staticRouteId,
			[Body]StaticRouteUpdateRequest updateNetworkStaticRoute);
	}
}
