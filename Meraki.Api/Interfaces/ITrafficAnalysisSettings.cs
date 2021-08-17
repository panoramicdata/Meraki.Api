using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ITrafficAnalysisSettings
	{
		/// <summary>
		/// Return the traffic analysis settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/trafficAnalysis")]
		Task<TrafficAnalysisSettingsUpdateRequest> GetNetworkTrafficAnalysisAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the traffic analysis settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkTrafficAnalysisSettings"></param>
		[Put("/networks/{networkId}/trafficAnalysis")]
		Task<TrafficAnalysisSettingsUpdateRequest> UpdateNetworkTrafficAnalysisAsync(
			[AliasAs("networkId")]string networkId,
			[Body]TrafficAnalysisSettingsUpdateRequest UpdateNetworkTrafficAnalysisSettings,
			CancellationToken cancellationToken = default
			);
	}
}
