namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplicationTrafficShapingUplinkSelection
{
	/// <summary>
	/// Show uplink selection settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
	Task<UplinkSelection> GetTrafficShapingUpinkSelectionAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update uplink selection settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateTrafficShapingUplinkSelection"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
	Task<UplinkSelection> UpdateTrafficShapingUplinkSelectionAsync(
		[AliasAs("networkId")] string networkId,
		[Body] UplinkSelection updateTrafficShapingUplinkSelection,
		CancellationToken cancellationToken = default
		);
}
