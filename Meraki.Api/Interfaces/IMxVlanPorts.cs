using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxVlanPorts
	{
		/// <summary>
		/// getNetworkAppliancePort
		/// </summary>
		/// <remarks>
		/// Return per-port VLAN settings for a single MX port.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="appliancePortId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliancePorts/{appliancePortId}")]
		Task<object> GetNetworkAppliancePort(
			[AliasAs("networkId")]string networkId,
			[AliasAs("appliancePortId")]string appliancePortId
			);

		/// <summary>
		/// getNetworkAppliancePorts
		/// </summary>
		/// <remarks>
		/// List per-port VLAN settings for all ports of a MX.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliancePorts")]
		Task<object> GetNetworkAppliancePorts(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkAppliancePort
		/// </summary>
		/// <remarks>
		/// Update the per-port VLAN settings for a single MX port.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="appliancePortId"></param>
		/// <param name="updateNetworkAppliancePort"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliancePorts/{appliancePortId}")]
		Task<object> UpdateNetworkAppliancePort(
			[AliasAs("networkId")]string networkId,
			[AliasAs("appliancePortId")]string appliancePortId,
			[Body]UpdateNetworkAppliancePort updateNetworkAppliancePort
			);
	}
}
