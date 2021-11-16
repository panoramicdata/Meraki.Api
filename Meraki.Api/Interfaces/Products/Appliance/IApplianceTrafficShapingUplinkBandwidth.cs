namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShapingUplinkBandwidth
{
	/// <summary>
	/// Returns the uplink bandwidth settings for your MX network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
	Task<UplinkBandwidth> GetNetworkApplianceTrafficShapingUplinkBandwidthAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates the uplink bandwidth settings for your MX network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateTrafficShapingUplinkBandwidth"></param>
	[Put("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
	Task<UplinkBandwidth> UpdateNetworkApplianceTrafficShapingUplinkBandwidthAsync(
		[AliasAs("networkId")] string networkId,
		[Body] UplinkBandwidth updateTrafficShapingUplinkBandwidth,
		CancellationToken cancellationToken = default
		);
}
