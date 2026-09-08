namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IAppliance Vpn Statuses
/// </summary>

public static class IApplianceVpnStatusesExtensions
{
	/// <summary>
	/// Show all VPN statuses for networks in an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call.</exception>
	/// <param name="applianceVpnStatuses"></param>
	/// <param name="organizationId">The organization id.</param>
	/// <param name="networkIds">A list of Meraki network IDs to filter results to contain only specified networks. E.g.: networkIds[]=N_12345678&amp;networkIds[]=L_3456</param>
	/// <param name="cancellationToken">Cancellation token to cancel the request.</param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<VpnStatus>> GetOrganizationApplianceVpnStatusesAllAsync(
		this IApplianceVpnStatuses applianceVpnStatuses,
		string organizationId,
		List<string>? networkIds = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, endingBefore, cancellationToken)
			=> applianceVpnStatuses.GetOrganizationApplianceVpnStatusesApiResponseAsync(
				organizationId,
				startingAfter,
				endingBefore,
				networkIds,
				cancellationToken
			),
			cancellationToken
		);
}
