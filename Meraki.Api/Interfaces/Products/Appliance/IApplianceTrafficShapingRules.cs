namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShapingRules
{
	/// <summary>
	/// Display the traffic shaping settings rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceTrafficShapingRules")]
	[Get("/networks/{networkId}/appliance/trafficShaping/rules")]
	Task<NetworkApplianceTrafficShapingRule> GetNetworkApplianceTrafficShapingRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Display the traffic shaping settings rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trafficShapingRule"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceTrafficShapingRules")]
	[Put("/networks/{networkId}/appliance/trafficShaping/rules")]
	Task<NetworkApplianceTrafficShapingRule> UpdateNetworkApplianceTrafficShapingRulesAsync(
		string networkId,
		[Body] NetworkApplianceTrafficShapingRule trafficShapingRule,
		CancellationToken cancellationToken = default
		);
}
