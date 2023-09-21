namespace Meraki.Api.Extensions;

public static class IApplianceTrafficShapingVpnExclusionsExtensions
{
	/// <summary>
	/// Display all VPN exclusion rules for MX networks.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkIds">Optional parameter to filter the results by network IDs</param>
	public static Task<List<TrafficShapingVpnExclusionsByNetwork>> GetNetworkApplianceTrafficShapingRulesAllAsync(
		this IApplianceTrafficShapingVpnExclusions applianceTrafficShapingVpnExclusions,
		string organizationId,
		List<string>? networkIds,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> applianceTrafficShapingVpnExclusions.GetNetworkApplianceTrafficShapingRulesApiResponseAsync(
						organizationId,
						startingAfter,
						networkIds,
						cancellationToken
					),
					cancellationToken
			);
}
