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
	public interface ISwitchStacks
	{
		/// <summary>
		/// addNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Add a switch to a stack
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <param name="addNetworkSwitchStack"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switch/switchStacks/{switchStackId}/add")]
		Task<object> AddNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[Body] NetworkSwitchStackCreationRequest addNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// createNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Create a stack
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSwitchStack"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switch/switchStacks")]
		Task<SwitchStack> CreateNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchStackCreationRequest createNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// deleteNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Delete a stack
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/switch/switchStacks/{switchStackId}")]
		Task DeleteNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// getNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Show a switch stack
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/switchStacks/{switchStackId}")]
		Task<SwitchStack> GetNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// getNetworkSwitchStacks
		/// </summary>
		/// <remarks>
		/// List the switch stacks in a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/switchStacks")]
		Task<List<SwitchStack>> GetNetworkSwitchStacksAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// removeNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Remove a switch from a stack
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <param name="removeNetworkSwitchStack"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switch/switchStacks/{switchStackId}/remove")]
		Task<object> RemoveNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[Body] RemoveNetworkSwitchStack removeNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// getNetworkSwitchStackRoutingStaticRoute
		/// </summary>
		/// <remarks>
		/// Return a layer 3 static route for a switch stack
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="staticRouteId"></param>
		/// <param name="switchStackId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
		Task<SwitchStaticRoute> GetNetworkSwitchStackRoutingStaticRoute(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[AliasAs("staticRouteId")] string staticRouteId
			);

		/// <summary>
		/// updateNetworkSwitchStackRoutingStaticRoute
		/// </summary>
		/// <remarks>
		/// Update a layer 3 static route for a switch stack
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="staticRouteId"></param>
		/// <param name="switchStackId"></param>
		/// <param name="updateNetworkSwitchStackRoutingStaticRoute"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
		Task<SwitchStaticRoute> UpdateNetworkSwitchStackRoutingStaticRoute(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[AliasAs("staticRouteId")] string staticRouteId,
			[Body] SwitchStaticRouteCreationRequest updateNetworkSwitchStackRoutingStaticRoute
			);

		/// <summary>
		/// deleteNetworkSwitchStackRoutingStaticRoute
		/// </summary>
		/// <remarks>
		/// Delete a layer 3 static route for a switch stack
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <param name="staticRouteId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
		Task DeleteNetworkSwitchStackRoutingStaticRoute(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);
	}
}
