using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISplashSettings
	{
		/// <summary>
		/// getNetworkSsidSplashSettings
		/// </summary>
		/// <remarks>
		/// Display the splash page settings for the given SSID
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/ssids/{number}/splashSettings")]
		Task<object> GetNetworkSsidSplashSettings(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number
			);

		/// <summary>
		/// updateNetworkSsidSplashSettings
		/// </summary>
		/// <remarks>
		/// Modify the splash page settings for the given SSID
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkSsidSplashSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/ssids/{number}/splashSettings")]
		Task<object> UpdateNetworkSsidSplashSettings(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			[Body]UpdateNetworkSsidSplashSettings updateNetworkSsidSplashSettings
			);
	}
}
