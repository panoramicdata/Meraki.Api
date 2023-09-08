namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShapingUplinkBandwidth
{
	/// <summary>
	/// Returns the uplink bandwidth limits for your MX network.
	/// This may not reflect the affected device's hardware capabilities.
	/// For more information on your device's hardware capabilities, please consult our MX Family Datasheet - [https://meraki.cisco.com/product-collateral/mx-family-datasheet/?file]
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
	Task<UplinkBandwidth> GetNetworkApplianceTrafficShapingUplinkBandwidthAsync(
		string networkId,
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
		string networkId,
		[Body] UplinkBandwidth updateTrafficShapingUplinkBandwidth,
		CancellationToken cancellationToken = default
		);
}
