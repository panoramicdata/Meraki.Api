namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Ports
/// </summary>
public interface IAppliancePorts
{
	/// <summary>
	/// Return per-port VLAN settings for a single MX port.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="portId">The appliance port id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkAppliancePort")]
	[Get("/networks/{networkId}/appliance/ports/{portId}")]
	Task<AppliancePort> GetNetworkAppliancePortAsync(
		string networkId,
		string portId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List per-port VLAN settings for all ports of a MX.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkAppliancePorts")]
	[Get("/networks/{networkId}/appliance/ports")]
	Task<List<AppliancePort>> GetNetworkAppliancePortsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the per-port VLAN settings for a single MX port.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="portId">The appliance port id</param>
	/// <param name="appliancePort">Body for updating the per-port VLAN settings</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkAppliancePorts")]
	[Put("/networks/{networkId}/appliance/ports/{portId}")]
	Task<AppliancePort> UpdateNetworkAppliancePortAsync(
		string networkId,
		string portId,
		[Body] AppliancePortUpdateRequest appliancePort,
		CancellationToken cancellationToken = default
		);
}
