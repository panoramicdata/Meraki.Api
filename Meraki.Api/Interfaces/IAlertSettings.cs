using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAlertSettings
	{
		/// <summary>
		/// getNetworkAlertSettings
		/// </summary>
		/// <remarks>
		/// Return the alert configuration for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/alertSettings")]
		Task<object> GetNetworkAlertSettings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkAlertSettings
		/// </summary>
		/// <remarks>
		/// Update the alert configuration for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkAlertSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/alertSettings")]
		Task<object> UpdateNetworkAlertSettings(
			[AliasAs("networkId")]string networkId,
			[Body]UpdateNetworkAlertSettings updateNetworkAlertSettings = null!);
	}
}