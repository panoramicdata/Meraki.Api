namespace Meraki.Api.Interfaces.Products.Switch;

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
	[ApiOperationId("getNetworkSwitchStacks")]
	[Get("/networks/{networkId}/switch/stacks")]
	Task<List<SwitchStack>> GetNetworkSwitchStacksAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSwitchStack"></param>
	[ApiOperationId("createNetworkSwitchStack")]
	[Post("/networks/{networkId}/switch/stacks")]
	Task<SwitchStack> CreateNetworkSwitchStackAsync(
		string networkId,
		[Body] SwitchStackCreationRequest createNetworkSwitchStack,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Show a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	[ApiOperationId("getNetworkSwitchStack")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}")]
	Task<SwitchStack> GetNetworkSwitchStackAsync(
		string networkId,
		string switchStackId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	[ApiOperationId("deleteNetworkSwitchStack")]
	[Delete("/networks/{networkId}/switch/stacks/{switchStackId}")]
	Task DeleteNetworkSwitchStackAsync(
		string networkId,
		string switchStackId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a switch to a stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="addNetworkSwitchStack"></param>
	[ApiOperationId("addNetworkSwitchStack")]
	[Post("/networks/{networkId}/switch/stacks/{switchStackId}/add")]
	Task<SwitchStack> AddNetworkSwitchStackAsync(
		string networkId,
		string switchStackId,
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
	[ApiOperationId("removeNetworkSwitchStack")]
	[Post("/networks/{networkId}/switch/stacks/{switchStackId}/remove")]
	Task<SwitchStack> RemoveNetworkSwitchStackAsync(
		string networkId,
		string switchStackId,
		[Body] RemoveNetworkSwitchStack removeNetworkSwitchStack,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List layer 3 interfaces for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchStackRoutingInterfaces")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces")]
	Task<List<RoutingInterface>> GetNetworkSwitchStackRoutingInterfacesAsync(
		string networkId,
		string switchStackId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a layer 3 interface for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="routingInterface"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createNetworkSwitchStackRoutingInterface")]
	[Post("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces")]
	Task<RoutingInterface> CreateNetworkSwitchStackRoutingInterfaceAsync(
		string networkId,
		string switchStackId,
		[Body] RoutingInterfaceCreateRequest routingInterface,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a layer 3 interface from a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="interfaceId"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchStackRoutingInterface")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}")]
	Task<RoutingInterface> GetNetworkSwitchStackRoutingInterfaceAsync(
		string networkId,
		string switchStackId,
		string interfaceId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a layer 3 interface for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="interfaceId"></param>
	/// <param name="routingInterface"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkSwitchStackRoutingInterface")]
	[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}")]
	Task<RoutingInterface> UpdateNetworkSwitchStackRoutingInterfaceAsync(
		string networkId,
		string switchStackId,
		string interfaceId,
		[Body] RoutingInterfaceUpdateRequest routingInterface,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a layer 3 interface from a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId"></param>
	/// <param name="interfaceId"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteNetworkSwitchStackRoutingInterface")]
	[Delete("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}")]
	Task DeleteNetworkSwitchStackRoutingInterfaceAsync(
		string networkId,
		string switchStackId,
		string interfaceId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a layer 3 interface DHCP configuration for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="interfaceId">The interface id</param>
	[ApiOperationId("getNetworkSwitchStackRoutingInterfaceDhcp")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}/dhcp")]
	Task<RoutingInterfaceDhcp> GetNetworkSwitchStackRoutingInterfaceDhcpAsync(
		string networkId,
		string switchStackId,
		string interfaceId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a layer 3 interface DHCP configuration for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="interfaceId">The interface id</param>
	/// <param name="routingInterfaceDhcp"></param>
	[ApiOperationId("updateNetworkSwitchStackRoutingInterfaceDhcp")]
	[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/interfaces/{interfaceId}/dhcp")]
	Task<RoutingInterfaceDhcp> UpdateNetworkSwitchStackRoutingInterfaceDhcpAsync(
		string networkId,
		string switchStackId,
		string interfaceId,
		[Body] RoutingInterfaceDhcp routingInterfaceDhcp,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List layer 3 static routes for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	[ApiOperationId("getNetworkSwitchStackRoutingStaticRoutes")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes")]
	Task<List<SwitchStaticRoute>> GetNetworkSwitchStackRoutingStaticRoutesAsync(
		string networkId,
		string switchStackId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a layer 3 static route for a switch stack
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="switchStackId">The switch stack id</param>
	/// <param name="createNetworkSwitchStackRoutingStaticRoute"></param>
	[ApiOperationId("createNetworkSwitchStackRoutingStaticRoute")]
	[Post("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes")]
	Task<SwitchStaticRoute> CreateNetworkSwitchStackRoutingStaticRouteAsync(
		string networkId,
		string switchStackId,
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
	[ApiOperationId("getNetworkSwitchStackRoutingStaticRoute")]
	[Get("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
	Task<SwitchStaticRoute> GetNetworkSwitchStackRoutingStaticRouteAsync(
		string networkId,
		string switchStackId,
		string staticRouteId,
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
	[ApiOperationId("updateNetworkSwitchStackRoutingStaticRoute")]
	[Put("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
	Task<SwitchStaticRoute> UpdateNetworkSwitchStackRoutingStaticRouteAsync(
		string networkId,
		string switchStackId,
		string staticRouteId,
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
	[ApiOperationId("deleteNetworkSwitchStackRoutingStaticRoute")]
	[Delete("/networks/{networkId}/switch/stacks/{switchStackId}/routing/staticRoutes/{staticRouteId}")]
	Task DeleteNetworkSwitchStackRoutingStaticRouteAsync(
		string networkId,
		string switchStackId,
		string staticRouteId,
		CancellationToken cancellationToken = default
		);
}
