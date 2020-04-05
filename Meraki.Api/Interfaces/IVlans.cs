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
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkVlan"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/vlans")]
		Task<Vlan> CreateAsync(
			[AliasAs("networkId")]string networkId,
			[Body]VlanCreationRequest createNetworkVlan,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteNetworkVlan
		/// </summary>
		/// <remarks>
		/// Delete a VLAN from a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="vlanId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/vlans/{vlanId}")]
		Task DeleteAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("vlanId")]string vlanId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkVlan
		/// </summary>
		/// <remarks>
		/// Return a VLAN
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="vlanId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/vlans/{vlanId}")]
		Task<Vlan> GetAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("vlanId")]string vlanId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkVlans
		/// </summary>
		/// <remarks>
		/// List the VLANs for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/vlans")]
		Task<List<Vlan>> GetAllAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkVlansEnabledState
		/// </summary>
		/// <remarks>
		/// Returns the enabled status of VLANs for the network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/vlansEnabledState")]
		Task<VlansEnabledState> GetNetworkVlansEnabledState(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkVlan
		/// </summary>
		/// <remarks>
		/// Update a VLAN
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="vlanId"></param>
		/// <param name="vlanSpec"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/vlans/{vlanId}")]
		Task<Vlan> UpdateAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("vlanId")]string vlanId,
			[Body]VlanSpec vlanSpec,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkVlansEnabledState
		/// </summary>
		/// <remarks>
		/// Enable/Disable VLANs for the given network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkVlansEnabledState"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/vlansEnabledState")]
		Task<VlansEnabledState> UpdateNetworkVlansEnabledState(
			[AliasAs("networkId")]string networkId,
			[Body]VlansEnabledState updateNetworkVlansEnabledState
			);
	}
}
