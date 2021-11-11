using Meraki.Api.Attributes;
using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces;

public interface ISwitchRoutingMulticast
{
	/// <summary>
	/// Return multicast settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchRoutingMulticast")]
	[Get("/networks/{networkId}/switch/routing/multicast")]
	Task<Multicast> GetNetworkSwitchRoutingMulticastAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update multicast settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="multicast"></param>
	[ApiOperationId("updateNetworkSwitchRoutingMulticast")]
	[Put("/networks/{networkId}/switch/routing/multicast")]
	Task<Multicast> UpdateNetworkSwitchRoutingMulticastAsync(
		[AliasAs("networkId")] string networkId,
		[Body] Multicast multicast,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List multicast rendezvous points
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchRoutingMulticastRendezvousPoints")]
	[Get("/networks/{networkId}/switch/routing/multicast/rendezvousPoints")]
	Task<List<RendezvousPoint>> GetNetworkSwitchRoutingMulticastRendezvousPointsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a multicast rendezvous points
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rendezvousPoint">The rendezvous point to create</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createNetworkSwitchRoutingMulticastRendezvousPoint")]
	[Post("/networks/{networkId}/switch/routing/multicast/rendezvousPoints")]
	Task<RendezvousPoint> CreateNetworkSwitchRoutingMulticastRendezvousPointAsync(
		[AliasAs("networkId")] string networkId,
		[Body] RendezvousPointCreateUpdateRequest rendezvousPoint,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Get a multicast rendezvous points
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchRoutingMulticastRendezvousPoint")]
	[Get("/networks/{networkId}/switch/routing/multicast/rendezvousPoints/{rendezvousPointId}")]
	Task<RendezvousPoint> GetNetworkSwitchRoutingMulticastRendezvousPointAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("rendezvousPointId")] string rendezvousPointId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a multicast rendezvous points
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rendezvousPoint">The rendezvous point to update</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkSwitchRoutingMulticastRendezvousPoint")]
	[Put("/networks/{networkId}/switch/routing/multicast/rendezvousPoints/{rendezvousPointId}")]
	Task<RendezvousPoint> UpdateNetworkSwitchRoutingMulticastRendezvousPointAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("rendezvousPointId")] string rendezvousPointId,
		[Body] RendezvousPointCreateUpdateRequest rendezvousPoint,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a multicast rendezvous points
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("deleteNetworkSwitchRoutingMulticastRendezvousPoint")]
	[Delete("/networks/{networkId}/switch/routing/multicast/rendezvousPoints/{rendezvousPointId}")]
	Task<RendezvousPoint> DeleteNetworkSwitchRoutingMulticastRendezvousPointAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("rendezvousPointId")] string rendezvousPointId,
		CancellationToken cancellationToken = default
		);
}
