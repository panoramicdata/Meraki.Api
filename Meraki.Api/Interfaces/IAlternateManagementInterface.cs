using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAlternateManagementInterface
	{
		/// <summary>
		/// Return the switch alternate management interface for the network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/alternateManagementInterface")]
		Task<AlternateManagementInterface> GetNetworkSwitchAlternateManagementInterfaceAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the switch alternate management interface for the network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSwitchAlternateManagementInterface">Body for updating network switch alternate management interface</param>
		[Put("/networks/{networkId}/switch/alternateManagementInterface")]
		Task<AlternateManagementInterface> UpdateNetworkSwitchAlternateManagementInterfaceAsync(
			[AliasAs("networkId")] string networkId,
			[Body] AlternateManagementInterface UpdateNetworkSwitchAlternateManagementInterface,
			CancellationToken cancellationToken = default
			);
	}
}
