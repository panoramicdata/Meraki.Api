namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplicationTrafficShapingRules
{
	/// <summary>
	/// Display the traffic shaping settings rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceTrafficShapingRules")]
	[Get("/networks/{networkId}/appliance/trafficShaping/rules")]
	Task<NetworkApplianceTrafficShapingRule> GetTrafficShapingRulesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Display the traffic shaping settings rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trafficShapingRule"></param>
	[ApiOperationId("getNetworkApplianceTrafficShapingRules")]
	[Put("/networks/{networkId}/appliance/trafficShaping/rules")]
	Task<NetworkApplianceTrafficShapingRule> UpdateTrafficShapingRulesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkApplianceTrafficShapingRule trafficShapingRule,
		CancellationToken cancellationToken = default
		);
}
