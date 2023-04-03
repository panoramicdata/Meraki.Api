namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksTrafficAnalysis
{
	/// <summary>
	/// Return the traffic analysis settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/trafficAnalysis")]
	Task<TrafficAnalysis> GetNetworkTrafficAnalysisAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the traffic analysis settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trafficAnalysis"></param>
	[Put("/networks/{networkId}/trafficAnalysis")]
	Task<TrafficAnalysis> UpdateNetworkTrafficAnalysisAsync(
		string networkId,
		[Body] TrafficAnalysis trafficAnalysis,
		CancellationToken cancellationToken = default
		);
}
