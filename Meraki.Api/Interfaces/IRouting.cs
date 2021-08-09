using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IRouting
	{
		/// <summary>
		/// getDeviceSwitchRoutingInterfaces
		/// </summary>
		/// <remarks>
		/// List layer 3 interfaces for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switch/routing/interfaces")]
		Task<List<RoutingInterface>> GetDeviceSwitchRoutingInterfaces(
			[AliasAs("serial")] string serial
			);

		/// <summary>
		/// createDeviceSwitchRoutingInterface
		/// </summary>
		/// <remarks>
		/// Create a layer 3 interface for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Post("/devices/{serial}/switch/routing/interfaces")]
		Task<object> CreateDeviceSwitchRoutingInterface(
			[AliasAs("serial")] string serial,
			[Body]RoutingInterface createDeviceSwitchRoutingInterface
			);

		/// <summary>
		/// getDeviceSwitchRoutingInterface
		/// </summary>
		/// <remarks>
		/// Return a layer 3 interface for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="interfaceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
		Task<RoutingInterface> GetDeviceSwitchRoutingInterface(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId
			);

		/// <summary>
		/// updateDeviceSwitchRoutingInterface
		/// </summary>
		/// <remarks>
		/// Return a layer 3 interface for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="interfaceId"></param>
		/// <param name="updateDeviceSwitchRoutingInterface"></param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
		Task<object> UpdateDeviceSwitchRoutingInterface(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
			[Body]RoutingInterfaceUpdateRequest updateDeviceSwitchRoutingInterface
			);

		/// <summary>
		/// deleteDeviceSwitchRoutingInterface
		/// </summary>
		/// <remarks>
		/// Delete a layer 3 interface from the switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="interfaceId"></param>
		/// <returns>Task of void</returns>
		[Delete("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
		Task DeleteAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getDeviceSwitchRoutingInterfaceDhcp
		/// </summary>
		/// <remarks>
		/// Return a layer 3 interface DHCP configuration for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="interfaceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switch/routing/interfaces/{interfaceId}/dhcp")]
		Task<DHCPRoutingInterface> GetDeviceSwitchRoutingInterfaceDhcp(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId
			);

		/// <summary>
		/// updateDeviceSwitchRoutingInterfaceDhcp
		/// </summary>
		/// <remarks>
		/// Update a layer 3 interface DHCP configuration for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="interfaceId"></param>
		/// <param name="updateDeviceSwitchRoutingInterfaceDhcp"></param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/switch/routing/interfaces/{interfaceId}")]
		Task<object> UpdateDeviceSwitchRoutingInterfaceDhcp(
			[AliasAs("serial")] string serial,
			[AliasAs("interfaceId")] string interfaceId,
			[Body] DHCPRoutingInterface updateDeviceSwitchRoutingInterfaceDhcp
			);

		/// <summary>
		/// getDeviceSwitchRoutingStaticRoutes
		/// </summary>
		/// <remarks>
		/// List layer 3 static routes for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switch/routing/staticRoutes")]
		Task<List<SwitchStaticRoute>> GetDeviceSwitchRoutingStaticRoutes(
			[AliasAs("serial")] string serial
			);

		/// <summary>
		/// getDeviceSwitchRoutingStaticRoute
		/// </summary>
		/// <remarks>
		/// Return a layer 3 static route for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="staticRouteId"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switch/routing/staticRoutes/{staticRouteId}")]
		Task<SwitchStaticRoute> GetDeviceSwitchRoutingStaticRoute(
			[AliasAs("serial")] string serial,
			[AliasAs("staticRouteId")] string staticRouteId
			);
	}
}
