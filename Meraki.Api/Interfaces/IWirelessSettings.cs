using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IWirelessSettings
	{
		/// <summary>
		/// getNetworkWirelessSettings
		/// </summary>
		/// <remarks>
		/// Return the wireless settings for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/settings")]
		Task<WirelessSettings> GetAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkWirelessSettings
		/// </summary>
		/// <remarks>
		/// Update the wireless settings for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkWirelessSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/settings")]
		Task<WirelessSettings> UpdateAsync(
			[AliasAs("networkId")]string networkId,
			[Body]WirelessSettingsUpdateDto updateNetworkWirelessSettings,
			CancellationToken cancellationToken = default);
	}
}
