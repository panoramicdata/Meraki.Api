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
	public interface IVlans
	{
		/// <summary>
		/// Add a VLAN
		/// </summary>
		/// <param name="networkId">The network id</param>
		/// <param name="VlanCreationRequest"></param>
		[Post("/networks/{networkId}/appliance/vlans")]
		Task<Vlan> CreateNetworkVlanAsync(
			[AliasAs("networkId")] string networkId,
			[Body] VlanCreationRequest VlanCreationRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete a VLAN from a network
		/// </summary>
		/// <param name="networkId">The network id</param>
		/// <param name="vlanId">The VLAN id</param>
		[Delete("/networks/{networkId}/appliance/vlans/{vlanId}")]
		Task DeleteNetworkVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("vlanId")] string vlanId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a VLAN
		/// </summary>
		/// <param name="networkId">The network id</param>
		/// <param name="vlanId">The VLAN id</param>
		[Get("/networks/{networkId}/appliance/vlans/{vlanId}")]
		Task<Vlan> GetNetworkVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("vlanId")] string vlanId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the VLANs for an MX network
		/// </summary>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/vlans")]
		Task<List<Vlan>> GetNetworkVlansAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the enabled status of VLANs for the network
		/// </summary>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/vlans/settings")]
		Task<VlansEnabledState> GetNetworkVlanEnabledStatesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a VLAN
		/// </summary>
		/// <param name="networkId">The network id</param>
		/// <param name="vlanId">The VLAN id</param>
		/// <param name="VlanSpec"></param>
		[Put("/networks/{networkId}/appliance/vlans/{vlanId}")]
		Task<Vlan> UpdateNetworkVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("vlanId")] string vlanId,
			[Body] VlanSpec VlanSpec,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Enable/Disable VLANs for the given network
		/// </summary>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkVlansEnabledState"></param>
		[Put("/networks/{networkId}/appliance/vlans/settings")]
		Task<VlansEnabledState> UpdateNetworkVlanEnabledStatesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] VlansEnabledState UpdateNetworkVlansEnabledState,
			CancellationToken cancellationToken = default
			);
	}
}
