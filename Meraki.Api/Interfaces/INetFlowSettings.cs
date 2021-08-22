using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetFlowSettings
	{
		/// <summary>
		/// Return the NetFlow traffic reporting settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/netflowSettings")]
		Task<NetflowSettingsUpdateRequest> GetNetworkNetflowSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the NetFlow traffic reporting settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkNetflowSettings">Body for updating netflow traffic</param>
		[Put("/networks/{networkId}/netflowSettings")]
		Task<NetflowSettingsUpdateRequest> UpdateNetworkNetflowSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetflowSettingsUpdateRequest updateNetworkNetflowSettings,
			CancellationToken cancellationToken = default
			);
	}
}
