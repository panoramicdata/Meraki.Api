using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IWirelessAlternateManagement
	{
		/// <summary>
		/// getNetworkWirelessAlternateManagementInterface
		/// </summary>
		/// <remarks>
		/// Return an action batch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/alternateManagementInterface")]
		Task<WirelessAlternateManagementInterface> GetNetworkWirelessAlternateManagementInterface(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkWirelessAlternateManagementInterface
		/// </summary>
		/// <remarks>
		/// Return an action batch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkWirelessAlternateManagementInterface"
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/alternateManagementInterface")]
		Task<WirelessAlternateManagementInterface> UpdateNetworkWirelessAlternateManagementInterface(
			[AliasAs("networkId")] string networkId,
			[Body] WirelessAlternateManagementInterface updateNetworkWirelessAlternateManagementInterface
			);
	}
}