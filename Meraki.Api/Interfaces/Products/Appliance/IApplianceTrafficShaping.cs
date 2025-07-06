namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShaping
{
	/// <summary>
	/// Display the traffic shaping settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceTrafficShaping")]
	[Get("/networks/{networkId}/appliance/trafficShaping")]
	Task<TrafficShaping> GetNetworkApplianceTrafficShapingAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the traffic shaping settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trafficShaping"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceTrafficShaping")]
	[Put("/networks/{networkId}/appliance/trafficShaping")]
	Task<TrafficShaping> UpdateNetworkApplianceTrafficShapingAsync(
		string networkId,
		[Body] TrafficShaping trafficShaping,
		CancellationToken cancellationToken = default
		);
}
