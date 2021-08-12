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
		/// createNetworkVlan
		/// </summary>
		/// <remarks>
		/// Add a VLAN
		/// </remarks>
		/// <param name="networkId">The network id</param>
		/// <param name="vlanCreationRequest"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/appliance/vlans")]
		Task<Vlan> CreateNetworkVlanAsync(
			[AliasAs("networkId")] string networkId,
			[Body] VlanCreationRequest vlanCreationRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete a Network VLAN
		/// </summary>
		/// <remarks>
		/// Delete a VLAN from a network
		/// </remarks>
		/// <param name="networkId">The network id</param>
		/// <param name="vlanId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/appliance/vlans/{vlanId}")]
		Task DeleteNetworkVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("vlanId")] string vlanId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Gets a Network VLAN
		/// </summary>
		/// <remarks>
		/// Return a VLAN
		/// </remarks>
		/// <param name="networkId">The network id</param>
		/// <param name="vlanId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/vlans/{vlanId}")]
		Task<Vlan> GetNetworkVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("vlanId")] string vlanId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Gets all network VLANs
		/// </summary>
		/// <remarks>
		/// List the VLANs for an MX network
		/// </remarks>
		/// <param name="networkId">The network id</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/vlans")]
		Task<List<Vlan>> GetNetworkVlansAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkVlansEnabledState
		/// </summary>
		/// <remarks>
		/// Returns the enabled status of VLANs for the network
		/// </remarks>
		/// <param name="networkId">The network id</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/vlans/settings")]
		Task<VlansEnabledState> GetNetworkVlanEnabledStatesAsync(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkVlan
		/// </summary>
		/// <remarks>
		/// Update a VLAN
		/// </remarks>
		/// <param name="networkId">The network id</param>
		/// <param name="vlanId"></param>
		/// <param name="vlanSpec"></param>
		/// <returns>Task of Vlan</returns>
		[Put("/networks/{networkId}/appliance/vlans/{vlanId}")]
		Task<Vlan> UpdateNetworkVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("vlanId")] string vlanId,
			[Body] VlanSpec vlanSpec,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkVlansEnabledState
		/// </summary>
		/// <remarks>
		/// Enable/Disable VLANs for the given network
		/// </remarks>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkVlansEnabledState"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/vlans/settings")]
		Task<VlansEnabledState> UpdateNetworkVlanEnabledStatesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] VlansEnabledState updateNetworkVlansEnabledState
			);
	}
}
