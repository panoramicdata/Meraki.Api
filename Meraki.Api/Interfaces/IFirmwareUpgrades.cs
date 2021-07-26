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
		/// getNetworkFirmwareUpgrades
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/firmwareUpgrades")]
		Task<object> GetNetworkFirmwareUpgradeAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkFirmwareUpgrades
		/// </summary>
		/// <remarks>
		/// updateNetworkFirmwareUpgrades
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkFirmwareUpgrades"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/firmwareUpgrades")]
		Task<object> UpdateNetworkFirmwareUpgradesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkFirmwareUpgradeUpdateRequest updateNetworkFirmwareUpgrades,
			CancellationToken cancellationToken = default);
	}
}