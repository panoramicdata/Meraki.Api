using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetFlowSettings
	{
		/// <summary>
		/// getNetworkNetflowSettings
		/// </summary>
		/// <remarks>
		/// Return the NetFlow traffic reporting settings for a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/netflowSettings")]
		Task<object> GetNetworkNetflowSettings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkNetflowSettings
		/// </summary>
		/// <remarks>
		/// Update the NetFlow traffic reporting settings for a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkNetflowSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/netflowSettings")]
		Task<object> UpdateNetworkNetflowSettings(
			[AliasAs("networkId")]string networkId,
			[Body]NetflowSettingsUpdateRequest updateNetworkNetflowSettings
			);
	}
}
