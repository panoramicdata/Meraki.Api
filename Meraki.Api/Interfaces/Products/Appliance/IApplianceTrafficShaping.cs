namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShaping
{
	/// <summary>
	/// Display the traffic shaping settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceTrafficShaping")]
	[Get("/networks/{networkId}/appliance/trafficShaping")]
	Task<TrafficShaping> GetNetworkApplianceTrafficShapingAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the traffic shaping settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trafficShaping"></param>
	[ApiOperationId("updateNetworkApplianceTrafficShaping")]
	[Put("/networks/{networkId}/appliance/trafficShaping")]
	Task<TrafficShaping> UpdateNetworkApplianceTrafficShapingAsync(
		[AliasAs("networkId")] string networkId,
		[Body] TrafficShaping trafficShaping,
		CancellationToken cancellationToken = default
		);
}
