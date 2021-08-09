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
		/// getNetworkFirmwareUpgrades
		/// </summary>
		/// <remarks>
		/// Get firmware upgrade information for a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/firmwareUpgrades")]
		Task<NetworkFirmwareUpgrade> GetNetworkFirmwareUpgradeAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkFirmwareUpgrades
		/// </summary>
		/// <remarks>
		/// Update firmware upgrade information for a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkFirmwareUpgrades"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/firmwareUpgrades")]
		Task<NetworkFirmwareUpgrade> UpdateNetworkFirmwareUpgradesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkFirmwareUpgradeUpdateRequest updateNetworkFirmwareUpgrades,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// createNetworkFirmwareUpgradesRollback
		/// </summary>
		/// <remarks>
		/// Rollback a Firmware Upgrade For A Network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkFirmwareUpgradesRollback"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/firmwareUpgrades/rollbacks")]
		Task<NetworkFirmwareUpgrade> CreateNetworkFirmwareUpgradesRollback(
			[AliasAs("networkId")] string networkId,
			[Body]FirmwareUpgradeRollbackRequest createNetworkFirmwareUpgradesRollback,
			CancellationToken cancellationToken = default
			);
	}
}