using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISplashSettings
	{
		/// <summary>
		/// Display the splash page settings for the given SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
		Task<SsidSplashSettingsUpdateRequest> GetNetworkSsidSplashSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Modify the splash page settings for the given SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="updateNetworkSsidSplashSettings"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
		Task<SsidSplashSettingsUpdateRequest> UpdateNetworkSsidSplashSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] SsidSplashSettingsUpdateRequest updateNetworkSsidSplashSettings,
			CancellationToken cancellationToken = default
			);
	}
}
