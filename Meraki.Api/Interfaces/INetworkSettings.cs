using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkSettings
	{
		/// <summary>
		/// Return the settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/settings")]
		Task<NetworkSettings> GetNetworkSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSettings">Body for updating network settings</param>
		[Put("/networks/{networkId}/settings")]
		Task<NetworkSettings> UpdateNetworkSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkSettings UpdateNetworkSettings,
			CancellationToken cancellationToken = default
			);
	}
}