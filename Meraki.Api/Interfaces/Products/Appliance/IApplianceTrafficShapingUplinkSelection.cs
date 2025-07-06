﻿namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShapingUplinkSelection
{
	/// <summary>
	/// Show uplink selection settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
	Task<UplinkSelection> GetNetworkApplianceTrafficShapingUplinkSelectionAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update uplink selection settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateTrafficShapingUplinkSelection"></param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Put("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
	Task<UplinkSelection> UpdateNetworkApplianceTrafficShapingUplinkSelectionAsync(
		string networkId,
		[Body] UplinkSelection updateTrafficShapingUplinkSelection,
		CancellationToken cancellationToken = default
		);
}
