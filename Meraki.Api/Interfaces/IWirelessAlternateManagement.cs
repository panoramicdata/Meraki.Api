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
		/// Return an action batch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/wireless/alternateManagementInterface")]
		Task<WirelessAlternateManagementInterface> GetNetworkWirelessAlternateManagementInterfaceAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update an action batch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkWirelessAlternateManagementInterface"></param>
		[Put("/networks/{networkId}/wireless/alternateManagementInterface")]
		Task<WirelessAlternateManagementInterface> UpdateNetworkWirelessAlternateManagementInterfaceAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WirelessAlternateManagementInterface UpdateNetworkWirelessAlternateManagementInterface,
			CancellationToken cancellationToken = default
			);
	}
}