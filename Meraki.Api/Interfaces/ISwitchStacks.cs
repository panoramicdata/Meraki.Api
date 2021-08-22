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
		/// Add a switch to a stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="AddNetworkSwitchStack"></param>
		[Post("/networks/{networkId}/switch/switchStacks/{switchStackId}/add")]
		Task<SwitchStack> AddNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[Body] NetworkSwitchStackCreationRequest AddNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Create a stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkSwitchStack"></param>
		[Post("/networks/{networkId}/switch/switchStacks")]
		Task<SwitchStack> CreateNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchStackCreationRequest CreateNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		[Delete("/networks/{networkId}/switch/switchStacks/{switchStackId}")]
		Task DeleteNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Show a switch stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		[Get("/networks/{networkId}/switch/switchStacks/{switchStackId}")]
		Task<SwitchStack> GetNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the switch stacks in a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/switchStacks")]
		Task<List<SwitchStack>> GetNetworkSwitchStacksAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Remove a switch from a stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="RemoveNetworkSwitchStack"></param>
		[Post("/networks/{networkId}/switch/switchStacks/{switchStackId}/remove")]
		Task<SwitchStack> RemoveNetworkSwitchStackAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[Body] RemoveNetworkSwitchStack RemoveNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a layer 3 static route for a switch stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="staticRouteId">The static route id</param>
		[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
		Task<SwitchStaticRoute> GetNetworkSwitchStackRoutingStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a layer 3 static route for a switch stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="staticRouteId">The static route id</param>
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="UpdateNetworkSwitchStackRoutingStaticRoute"></param>
		[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
		Task<SwitchStaticRoute> UpdateNetworkSwitchStackRoutingStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[AliasAs("staticRouteId")] string staticRouteId,
			[Body] SwitchStaticRouteCreationRequest UpdateNetworkSwitchStackRoutingStaticRoute,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a layer 3 static route for a switch stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="staticRouteId">The static route id</param>
		[Delete("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
		Task DeleteNetworkSwitchStackRoutingStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);
	}
}
