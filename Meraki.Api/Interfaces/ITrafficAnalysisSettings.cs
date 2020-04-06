using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ITrafficAnalysisSettings
	{
		/// <summary>
		/// getNetworkTrafficAnalysisSettings
		/// </summary>
		/// <remarks>
		/// Return the traffic analysis settings for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/trafficAnalysisSettings")]
		Task<object> GetNetworkTrafficAnalysisSettings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkTrafficAnalysisSettings
		/// </summary>
		/// <remarks>
		/// Update the traffic analysis settings for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkTrafficAnalysisSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/trafficAnalysisSettings")]
		Task<object> UpdateNetworkTrafficAnalysisSettings(
			[AliasAs("networkId")]string networkId,
			[Body]TrafficAnalysisSettingsUpdateRequest updateNetworkTrafficAnalysisSettings
			);
	}
}
