namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Traffic Shaping Vpn Exclusions
/// </summary>
public interface IApplianceTrafficShapingVpnExclusions
{
	/// <summary>
	/// Display VPN exclusion rules for MX networks.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 50.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="networkIds">Optional parameter to filter the results by network IDs</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationApplianceTrafficShapingVpnExclusionsByNetwork")]
	[Get("/organizations/{organizationId}/appliance/trafficShaping/vpnExclusions/byNetwork")]
	Task<TrafficShapingVpnExclusionsByNetworkResponse> GetOrganizationApplianceTrafficShapingVpnExclusionsByNetworkAsync(
		string organizationId,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		[AliasAs("networkIds[]")] List<string> networkIds,
		CancellationToken cancellationToken = default
		);

	///// <summary>
	///// Display VPN exclusion rules for MX networks. Used internally for the GetAll endpoint
	///// </summary>
	///// <exception cref="ApiException">Thrown when fails to make API call</exception>
	///// <param name="organizationId">The organization id</param>
	///// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	///// <param name="networkIds">Optional parameter to filter the results by network IDs</param>
	//[ApiOperationId("getOrganizationApplianceTrafficShapingVpnExclusionsByNetwork")]
	//[Get("/organizations/{organizationId}/appliance/trafficShaping/vpnExclusions/byNetwork")]
	//internal Task<ApiResponse<TrafficShapingVpnExclusionsByNetworkResponse>> GetOrganizationApplianceTrafficShapingVpnExclusionsByNetworkApiResponseAsync(
	//	string organizationId,
	//	string? startingAfter,
	//	[AliasAs("networkIds[]")] List<string>? networkIds,
	//	CancellationToken cancellationToken = default
	//	);

	/// <summary>
	/// Update VPN exclusion rules for an MX network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trafficShapingVpnExclusions">Traffic Shaping Vpn Exclusions</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceTrafficShapingVpnExclusions")]
	[Put("/networks/{networkId}/appliance/trafficShaping/vpnExclusions")]
	Task<TrafficShapingVpnExclusionsByNetworkResponse> UpdateNetworkApplianceTrafficShapingVpnExclusionsAsync(
		string networkId,
		[Body] TrafficShapingVpnExclusions trafficShapingVpnExclusions,
		CancellationToken cancellationToken = default
		);
}
