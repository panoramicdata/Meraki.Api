namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShapingVpnExclusions
{
	/// <summary>
	/// Display VPN exclusion rules for MX networks.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizatonId">The organization id</param>
	[ApiOperationId("getOrganizationApplianceTrafficShapingVpnExclusionsByNetwork")]
	[Get("/organizations/{organizationId}/appliance/trafficShaping/vpnExclusions/byNetwork")]
	Task<List<TrafficShapingVpnExclusionsByNetwork>> GetNetworkApplianceTrafficShapingRulesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update VPN exclusion rules for an MX network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trafficShapingVpnExclusions">Traffic Shaping Vpn Exclusions</param>
	[ApiOperationId("updateNetworkApplianceTrafficShapingVpnExclusions")]
	[Put("/networks/{networkId}/appliance/trafficShaping/vpnExclusions")]
	Task<TrafficShapingVpnExclusionsByNetwork> UpdateNetworkApplianceTrafficShapingVpnExclusionsAsync(
		string networkId,
		[Body] TrafficShapingVpnExclusions trafficShapingVpnExclusions,
		CancellationToken cancellationToken = default
		);
}
