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
	public interface IMxVlanPorts
	{
		/// <summary>
		/// Return per-port VLAN settings for a single MX port.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="appliancePortId">The appliance port id</param>
		[Get("/networks/{networkId}/appliance/ports/{portId}")]
		Task<NetworkAppliancePortUpdateRequest> GetNetworkAppliancePortAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("portId")]string appliancePortId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List per-port VLAN settings for all ports of a MX.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</experception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/ports")]
		Task<List<NetworkAppliancePortUpdateRequest>> GetNetworkAppliancePortsAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the per-port VLAN settings for a single MX port.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="appliancePortId">The appliance port id</param>
		/// <param name="UpdateNetworkAppliancePort">Body for updating the per-port VLAN settings</param>
		[Put("/networks/{networkId}/appliancePorts/{appliancePortId}")]
		Task<NetworkAppliancePortUpdateRequest> UpdateNetworkAppliancePortAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("appliancePortId")]string appliancePortId,
			[Body]NetworkAppliancePortUpdateRequest UpdateNetworkAppliancePort,
			CancellationToken cancellationToken = default
			);
	}
}
