namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IAppliance Uplink Statuses
/// </summary>
public static class IApplianceUplinkStatusesExtensions
{
	/// <summary>
	/// List the uplink status of every Meraki MX and Z series appliance in the organization, fetching every page.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call.</exception>
	/// <param name="applianceUplinkStatuses"></param>
	/// <param name="organizationId">The organization id.</param>
	/// <param name="networkIds">A list of network IDs. The returned devices will be filtered to only include these networks.</param>
	/// <param name="serials">A list of serial numbers. The returned devices will be filtered to only include these serials.</param>
	/// <param name="iccids">A list of ICCIDs. The returned devices will be filtered to only include these ICCIDs.</param>
	/// <param name="cancellationToken">Cancellation token to cancel the request.</param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<UplinkStatus>> GetOrganizationApplianceUplinkStatusesAllAsync(
		this IApplianceUplinkStatuses applianceUplinkStatuses,
		string organizationId,
		List<string>? networkIds = null,
		List<string>? serials = null,
		List<string>? iccids = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, endingBefore, cancellationToken)
			=> applianceUplinkStatuses.GetOrganizationApplianceUplinkStatusesApiResponseAsync(
				organizationId,
				startingAfter,
				endingBefore,
				networkIds,
				serials,
				iccids,
				cancellationToken
			),
			cancellationToken
		);
}
