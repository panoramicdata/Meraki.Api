namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IAppliancePorts
{
	/// <summary>
	/// Return per-port VLAN settings for a single MX port.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="appliancePortId">The appliance port id</param>
	[ApiOperationId("getNetworkAppliancePort")]
	[Get("/networks/{networkId}/appliance/ports/{portId}")]
	Task<AppliancePort> GetNetworkAppliancePortAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("portId")] string appliancePortId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List per-port VLAN settings for all ports of a MX.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</experception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkAppliancePorts")]
	[Get("/networks/{networkId}/appliance/ports")]
	Task<List<AppliancePort>> GetNetworkAppliancePortsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the per-port VLAN settings for a single MX port.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="portId">The appliance port id</param>
	/// <param name="appliancePort">Body for updating the per-port VLAN settings</param>
	[ApiOperationId("updateNetworkAppliancePorts")]
	[Put("/networks/{networkId}/appliance/ports/{portId}")]
	Task<AppliancePort> UpdateNetworkAppliancePortAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("portId")] string portId,
		[Body] AppliancePort appliancePort,
		CancellationToken cancellationToken = default
		);
}
