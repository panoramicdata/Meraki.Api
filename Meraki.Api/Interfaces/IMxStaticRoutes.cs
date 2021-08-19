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
	public interface IMxStaticRoutes
	{
		/// <summary>
		/// Add a static route for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkStaticRoute">Body for adding a static route</param>
		[Post("/networks/{networkId}/staticRoutes")]
		Task<StaticRouteUpdateRequest> CreateNetworkStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[Body] StaticRouteCreationRequest CreateNetworkStaticRoute,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a static route from an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="staticRouteId">The static route id</param>
		[Delete("/networks/{networkId}/staticRoutes/{staticRouteId}")]
		Task DeleteNetworkStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a static route for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="staticRouteId">The static route id</param>
		[Get("/networks/{networkId}/staticRoutes/{staticRouteId}")]
		Task<StaticRouteUpdateRequest> GetNetworkStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the static routes for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/staticRoutes")]
		Task<List<StaticRouteUpdateRequest>> GetNetworkStaticRoutesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a static route for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="staticRouteId">The static route id</param>
		/// <param name="UpdateNetworkStaticRoute">Body for updating a static route</param>
		[Put("/networks/{networkId}/staticRoutes/{staticRouteId}")]
		Task<StaticRouteUpdateRequest> UpdateNetworkStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("staticRouteId")] string staticRouteId,
			[Body] StaticRouteUpdateRequest UpdateNetworkStaticRoute,
			CancellationToken cancellationToken = default);
	}
}
