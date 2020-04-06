using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxWarmSpareSettings
	{
		/// <summary>
		/// getNetworkWarmSpareSettings
		/// </summary>
		/// <remarks>
		/// Return MX warm spare settings
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/warmSpareSettings")]
		Task<object> GetNetworkWarmSpareSettings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// swapNetworkWarmspare
		/// </summary>
		/// <remarks>
		/// Swap MX primary and warm spare appliances
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/swapWarmSpare")]
		Task<object> SwapNetworkWarmspare(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkWarmSpareSettings
		/// </summary>
		/// <remarks>
		/// Update MX warm spare settings
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkWarmSpareSettings"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/warmSpareSettings")]
		Task<object> UpdateNetworkWarmSpareSettings(
			[AliasAs("networkId")]string networkId,
			[Body]WarmSpareSettingsUpdateRequest updateNetworkWarmSpareSettings
			);
	}
}
