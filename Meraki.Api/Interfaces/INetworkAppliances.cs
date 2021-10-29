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
	public interface INetworkAppliances
	{
		/// <summary>
		/// Return a static route for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="staticRouteId">The static route id</param>
		[Get("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
		Task<StaticRoute> GetStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the static routes for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/staticRoutes")]
		Task<List<StaticRoute>> GetStaticRoutesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Add a static route for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkStaticRoute">Body for adding a static route</param>
		[Post("/networks/{networkId}/appliance/staticRoutes")]
		Task<StaticRoute> CreateStaticRouteAsync(
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
		[Put("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
		Task<StaticRoute> UpdateStaticRouteAsync(
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
		[Delete("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
		Task DeleteStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);
	}
}
