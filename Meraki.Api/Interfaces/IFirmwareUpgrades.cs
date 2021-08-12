using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IFirmwareUpgrades
	{
		/// <summary>
		/// Get firmware upgrade information for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/firmwareUpgrades")]
		Task<NetworkFirmwareUpgrade> GetNetworkFirmwareUpgradeAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update firmware upgrade information for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkFirmwareUpgrades">Body for updating network firmware upgrades</param>
		[Put("/networks/{networkId}/firmwareUpgrades")]
		Task<NetworkFirmwareUpgrade> UpdateNetworkFirmwareUpgradesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkFirmwareUpgradeUpdateRequest UpdateNetworkFirmwareUpgrades,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// createNetworkFirmwareUpgradesRollback
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkFirmwareUpgradesRollback">Body for creating network firmware upgrade rollbacks</param>
		[Post("/networks/{networkId}/firmwareUpgrades/rollbacks")]
		Task<NetworkFirmwareUpgrade> CreateNetworkFirmwareUpgradesRollbackAsync(
			[AliasAs("networkId")] string networkId,
			[Body]FirmwareUpgradeRollbackRequest CreateNetworkFirmwareUpgradesRollback,
			CancellationToken cancellationToken = default
			);
	}
}