namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IAppliance Traffic Shaping Vpn Exclusions
/// </summary>

public static class IApplianceTrafficShapingVpnExclusionsExtensions
{
	/// <summary>
	/// Display all VPN exclusion rules for MX networks.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="applianceTrafficShapingVpnExclusions">ApplianceTrafficShapingVpnExclusions</param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkIds">Optional parameter to filter the results by network IDs</param>
	/// <param name="cancellationToken"></param>
	public static Task<TrafficShapingVpnExclusionsByNetworkResponse> GetOrganizationApplianceTrafficShapingVpnExclusionsByNetworkAllAsync(
		this IApplianceTrafficShapingVpnExclusions applianceTrafficShapingVpnExclusions,
		string organizationId,
		List<string>? networkIds,
		CancellationToken cancellationToken = default)
		=> throw new NotImplementedException("Waiting on meraki bugfix for this endpoint, it should not have 'items'");
	//MerakiClient.GetAllAsync(
	//			(startingAfter, cancellationToken)
	//			=> applianceTrafficShapingVpnExclusions.GetOrganizationApplianceTrafficShapingVpnExclusionsByNetworkApiResponseAsync(
	//					organizationId,
	//					startingAfter,
	//					networkIds,
	//					cancellationToken
	//				),
	//				cancellationToken
	//		);
}
