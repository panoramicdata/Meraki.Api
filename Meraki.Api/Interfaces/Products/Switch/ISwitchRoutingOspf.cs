namespace Meraki.Api.Interfaces.Products.Switch;
/// <summary>
/// I Switch Routing Ospf
/// </summary>
public interface ISwitchRoutingOspf
{
	/// <summary>
	/// Get layer 3 OSPF routing configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getNetworkSwitchRoutingOspf")]
	[Get("/networks/{networkId}/switch/routing/ospf")]
	Task<RoutingOspf> GetNetworkSwitchRoutingOspfAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update layer 3 OSPF routing configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="routingOspf">The OSPF routing configuration to update</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("updateNetworkSwitchRoutingOspf")]
	[Put("/networks/{networkId}/switch/routing/ospf")]
	Task<RoutingOspf> UpdateNetworkSwitchRoutingOspfAsync(
		string networkId,
		[Body] RoutingOspf routingOspf,
		CancellationToken cancellationToken = default
		);
}
