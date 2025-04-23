namespace Meraki.Api.Interfaces.Products.Switch;
public interface ISwitchRoutingInterfaces
{
	/// <summary>
	/// List layer 3 interfaces for a switch. Those for a stack may be found under switch stack routing.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="mode">Optional parameter to filter L3 interfaces by mode.</param>"
	/// <param name="protocol">Optional parameter to filter L3 interfaces by protocol.</param>"
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getDeviceSwitchRoutingInterfaces")]
	[Get("/devices/{serial}/switch/routing/interfaces")]
	Task<List<RoutingInterface>> GetDeviceSwitchRoutingInterfacesAsync(
		string serial,
		L3InterfaceMode? mode = null,
		L3InterfaceProtocol? protocol = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a layer 3 interface for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="routingInterface"></param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("createDeviceSwitchRoutingInterface")]
	[Post("/devices/{serial}/switch/routing/interfaces")]
	Task<RoutingInterface> CreateDeviceSwitchRoutingInterfaceAsync(
		string serial,
		[Body] RoutingInterfaceCreateRequest routingInterface,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a layer 3 interface for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="interfaceId">The interface id</param>
	[ApiOperationId("getDeviceSwitchRoutingInterface")]
	[Get("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
	Task<RoutingInterface> GetDeviceSwitchRoutingInterfaceAsync(
		string serial,
		string interfaceId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a layer 3 interface for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="interfaceId">The interface id</param>
	/// <param name="updateRoutingInterface">Body for returning an interface</param>
	[ApiOperationId("updateDeviceSwitchRoutingInterface")]
	[Put("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
	Task<RoutingInterface> UpdateDeviceSwitchRoutingInterfaceAsync(
		string serial,
		string interfaceId,
		[Body] RoutingInterfaceUpdateRequest updateRoutingInterface,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a layer 3 interface from the switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="interfaceId">The interface id</param>
	[ApiOperationId("deleteDeviceSwitchRoutingInterface")]
	[Delete("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
	Task DeleteDeviceSwitchRoutingInterfaceAsync(
		string serial,
		string interfaceId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a layer 3 interface DHCP configuration for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="interfaceId">The interface id</param>
	[ApiOperationId("getDeviceSwitchRoutingInterfaceDhcp")]
	[Get("/devices/{serial}/switch/routing/interfaces/{interfaceId}/dhcp")]
	Task<RoutingInterfaceDhcp> GetDeviceSwitchRoutingInterfaceDhcpAsync(
		string serial,
		string interfaceId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a layer 3 interface DHCP configuration for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="interfaceId">The interface id</param>
	/// <param name="updateDeviceSwitchRoutingInterfaceDhcp">Body for updating an interface</param>
	[ApiOperationId("updateDeviceSwitchRoutingInterfaceDhcp")]
	[Put("/devices/{serial}/switch/routing/interfaces/{interfaceId}/dhcp")]
	Task<RoutingInterfaceDhcp> UpdateDeviceSwitchRoutingInterfaceDhcpAsync(
		string serial,
		string interfaceId,
		[Body] RoutingInterfaceDhcp updateDeviceSwitchRoutingInterfaceDhcp,
		CancellationToken cancellationToken = default
		);
}
