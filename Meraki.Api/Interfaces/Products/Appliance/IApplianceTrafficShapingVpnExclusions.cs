namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShapingVpnExclusions
{
	/// <summary>
	/// Update VPN exclusion rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trafficShapingVpnExclusionsUpdateRequest">The traffic shaping VPN exclusion update request</param>
	[ApiOperationId("updateNetworkApplianceTrafficShapingVpnExclusions")]
	[Put("/networks/{networkId}/appliance/trafficShaping/vpnExclusions")]
	Task<NetworkApplianceTrafficShapingVpnExclusionsUpdateResponse> UpdateNetworkApplianceTrafficShapingVpnExclusionsAsync(
		string networkId,
		[Body] NetworkApplianceTrafficShapingVpnExclusionsUpdateRequest trafficShapingVpnExclusionsUpdateRequest,
		CancellationToken cancellationToken = default
		);
}
