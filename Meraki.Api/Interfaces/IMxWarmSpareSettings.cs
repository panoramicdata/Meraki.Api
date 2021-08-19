using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxWarmSpareSettings
	{
		/// <summary>
		/// Return MX warm spare settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/warmSpareSettings")]
		Task<WarmSpare> GetNetworkWarmSpareSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Swap MX primary and warm spare appliances
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Post("/networks/{networkId}/swapWarmSpare")]
		Task<WarmSpare> SwapNetworkWarmspareAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update MX warm spare settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkWarmSpareSettings">Body for updating warm spare settings</param>
		[Put("/networks/{networkId}/warmSpareSettings")]
		Task<WarmSpare> UpdateNetworkWarmSpareSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WarmSpareSettingsUpdateRequest UpdateNetworkWarmSpareSettings,
			CancellationToken cancellationToken = default
			);
	}
}
