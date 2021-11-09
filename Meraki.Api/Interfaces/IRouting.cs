using Meraki.Api.Attributes;
using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IRouting
	{
		/// <summary>
		/// List layer 3 interfaces for a switch. Those for a stack may be found under switch stack routing.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[ApiOperationId("getDeviceSwitchRoutingInterfaces")]
		[Get("/devices/{serial}/switch/routing/interfaces")]
		Task<List<RoutingInterface>> GetDeviceSwitchRoutingInterfacesAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Create a layer 3 interface for a switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="routingInterface"></param>
		/// <param name="cancellationToken"></param>
		[ApiOperationId("createDeviceSwitchRoutingInterface")]
		[Post("/devices/{serial}/switch/routing/interfaces")]
		Task<RoutingInterface> CreateDeviceSwitchRoutingInterfaceAsync(
			[AliasAs("serial")] string serial,
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
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
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
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
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
		Task DeleteAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
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
		Task<DhcpRoutingInterface> GetDeviceSwitchRoutingInterfaceDhcpAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
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
		Task<DhcpRoutingInterface> UpdateDeviceSwitchRoutingInterfaceDhcpAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
			[Body] DhcpRoutingInterface updateDeviceSwitchRoutingInterfaceDhcp,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List layer 3 static routes for a switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[ApiOperationId("getDeviceSwitchRoutingStaticRoutes")]
		[Get("/devices/{serial}/switch/routing/staticRoutes")]
		Task<List<SwitchStaticRoute>> GetDeviceSwitchRoutingStaticRoutesAsync(
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
		Task<SwitchStaticRoute> GetDeviceSwitchRoutingStaticRouteAsync(
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
		Task<SwitchStaticRoute> CreateDeviceSwitchRoutingStaticRouteAsync(
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
		Task<SwitchStaticRoute> UpdateDeviceSwitchRoutingStaticRouteAsync(
			[AliasAs("serial")] string serial,
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
		Task<SwitchStaticRoute> DeleteDeviceSwitchRoutingStaticRouteAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);
	}
}
