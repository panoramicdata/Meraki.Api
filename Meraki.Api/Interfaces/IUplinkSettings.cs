using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IUplinkSettings
	{
		/// <summary>
		/// getNetworkUplinkSettings
		/// </summary>
		/// <remarks>
		/// Returns the uplink settings for your MX network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/uplinkSettings")]
		Task<object> GetNetworkUplinkSettings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkUplinkSettings
		/// </summary>
		/// <remarks>
		/// Updates the uplink settings for your MX network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkUplinkSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/uplinkSettings")]
		Task<object> UpdateNetworkUplinkSettings(
			[AliasAs("networkId")]string networkId,
			[Body]UplinkSettingsUpdateRequest updateNetworkUplinkSettings
			);
	}
}
