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
		/// List layer 3 interfaces for a switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
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
		[Post("/devices/{serial}/switch/routing/interfaces")]
		Task<RoutingInterface> CreateDeviceSwitchRoutingInterfaceAsync(
			[AliasAs("serial")] string serial,
			[Body] RoutingInterface CreateDeviceSwitchRoutingInterface,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a layer 3 interface for a switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="interfaceId">The interface id</param>
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
		/// <param name="UpdateDeviceSwitchRoutingInterface">Body for returning an interface</param>
		[Put("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
		Task<RoutingInterface> UpdateDeviceSwitchRoutingInterfaceAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
			[Body] RoutingInterfaceUpdateRequest UpdateDeviceSwitchRoutingInterface,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a layer 3 interface from the switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="interfaceId">The interface id</param>
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
		[Get("/devices/{serial}/switch/routing/interfaces/{interfaceId}/dhcp")]
		Task<DHCPRoutingInterface> GetDeviceSwitchRoutingInterfaceDhcpAsync(
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
		/// <param name="UpdateDeviceSwitchRoutingInterfaceDhcp">Body for updating an interface</param>
		[Put("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
		Task<DHCPRoutingInterface> UpdateDeviceSwitchRoutingInterfaceDhcpAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
			[Body] DHCPRoutingInterface UpdateDeviceSwitchRoutingInterfaceDhcp,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List layer 3 static routes for a switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
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
		[Get("/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}")]
		Task<SwitchStaticRoute> GetDeviceSwitchRoutingStaticRouteAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);
	}
}
