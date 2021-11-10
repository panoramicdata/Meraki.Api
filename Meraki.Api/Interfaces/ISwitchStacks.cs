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
		/// List the switch stacks in a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/stacks")]
		Task<List<SwitchStack>> GetAllAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkSwitchStack"></param>
		[Post("/networks/{networkId}/switch/stacks")]
		Task<SwitchStack> CreateAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchStackCreationRequest createNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Show a switch stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		[Get("/networks/{networkId}/switch/stacks/{switchStackId}")]
		Task<SwitchStack> GetAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		[Delete("/networks/{networkId}/switch/stacks/{switchStackId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Add a switch to a stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="addNetworkSwitchStack"></param>
		[Post("/networks/{networkId}/switch/stacks/{switchStackId}/add")]
		Task<SwitchStack> AddAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[Body] NetworkSwitchStackCreationRequest addNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Remove a switch from a stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="removeNetworkSwitchStack"></param>
		[Post("/networks/{networkId}/switch/stacks/{switchStackId}/remove")]
		Task<SwitchStack> RemoveAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[Body] RemoveNetworkSwitchStack removeNetworkSwitchStack,
			CancellationToken cancellationToken = default
			);

		// Routing
		/*
				// TODO GetNetworkSwitchStackRoutingInterfaces
				// TODO CreateNetworkSwitchStackRoutingInterface
				// TODO GetNetworkSwitchStackRoutingInterface
				// TODO UpdateNetworkSwitchStackRoutingInterface
				// TODO DeleteNetworkSwitchStackRoutingInterface

				// TODO Finish
				/// <summary>
				/// Return a layer 3 interface DHCP configuration for a switch stack
				/// </summary>
				/// <exception cref="ApiException">Thrown when fails to make API call</exception>
				/// <param name="networkId">The network id</param>
				/// <param name="switchStackId">The switch stack id</param>
				/// <param name="interfaceId">The interface id</param>
				[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}/dhcp")]
				Task<SwitchInterfaceRoute> GetNetworkSwitchStackRoutingInterfaceDhcpAsync(
					[AliasAs("networkId")] string networkId,
					[AliasAs("switchStackId")] string switchStackId,
					[AliasAs("interfaceId")] string interfaceId,
					CancellationToken cancellationToken = default
					);

				// TODO Finish
				/// <summary>
				/// Update a layer 3 interface DHCP configuration for a switch stack
				/// </summary>
				/// <exception cref="ApiException">Thrown when fails to make API call</exception>
				/// <param name="networkId">The network id</param>
				/// <param name="switchStackId">The switch stack id</param>
				/// <param name="interfaceId">The interface id</param>
				/// <param name="UpdateNetworkSwitchStackRoutingInterfaceDhcp"></param>
				[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}/dhcp")]
				Task<SwitchInterfaceRoute> UpdateNetworkSwitchStackRoutingInterfaceDhcp(
					[AliasAs("networkId")] string networkId,
					[AliasAs("switchStackId")] string switchStackId,
					[AliasAs("interfaceId")] string interfaceId,
					[Body] SwitchInterfaceUpdateRequest UpdateNetworkSwitchStackRoutingInterfaceDhcp,
					CancellationToken cancellationToken = default
					);
		*/

		/// <summary>
		/// List layer 3 static routes for a switch stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes")]
		Task<List<SwitchStaticRoute>> GetNetworkSwitchStackRoutingStaticRoutesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a layer 3 static route for a switch stack
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="createNetworkSwitchStackRoutingStaticRoute"></param>
		[Post("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes")]
		Task<SwitchStaticRoute> CreateNetworkSwitchStackRoutingStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[Body] SwitchStaticRouteCreationRequest createNetworkSwitchStackRoutingStaticRoute,
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
		/// <param name="switchStackId">The switch stack id</param>
		/// <param name="staticRouteId">The static route id</param>
		/// <param name="updateNetworkSwitchStackRoutingStaticRoute"></param>
		[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
		Task<SwitchStaticRoute> UpdateNetworkSwitchStackRoutingStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("switchStackId")] string switchStackId,
			[AliasAs("staticRouteId")] string staticRouteId,
			[Body] SwitchStaticRouteCreationRequest updateNetworkSwitchStackRoutingStaticRoute,
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
