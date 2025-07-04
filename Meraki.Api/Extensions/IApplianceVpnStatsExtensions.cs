namespace Meraki.Api.Extensions;

/// <summary>
/// Provides extension methods for retrieving VPN statistics from appliance VPN interfaces.
/// </summary>
/// <remarks>This static class contains methods that extend the functionality of the <see
/// cref="IApplianceVpnStats"/> interface, enabling asynchronous retrieval of VPN statistics for organizations and
/// networks.</remarks>
public static class IApplianceVpnStatsExtensions
{
	/// <summary>
	/// Retrieves VPN statistics for all networks in the specified organization.
	/// </summary>
	/// <remarks>This method asynchronously fetches VPN statistics for all networks within the given organization.
	/// The statistics can be filtered by a specific time range or timespan, and optionally by a list of network
	/// IDs.</remarks>
	/// <param name="applianceVpnStats">The interface used to access appliance VPN statistics.</param>
	/// <param name="organizationId">The unique identifier of the organization for which VPN statistics are retrieved. Cannot be null or empty.</param>
	/// <param name="t0">The start time for the statistics, in ISO 8601 format. If null, the time range is determined by <paramref
	/// name="timespan"/>.</param>
	/// <param name="t1">The end time for the statistics, in ISO 8601 format. If null, the time range is determined by <paramref
	/// name="timespan"/>.</param>
	/// <param name="timespan">The duration, in seconds, for which statistics are retrieved. If specified, <paramref name="t0"/> and <paramref
	/// name="t1"/> must be null.</param>
	/// <param name="networkIds">A list of network IDs to filter the statistics. If null, statistics for all networks in the organization are
	/// retrieved.</param>
	/// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <see cref="CancellationToken.None"/>.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="VpnStats"/>
	/// objects representing the VPN statistics for the specified organization.</returns>
	public static Task<List<VpnStats>> GetOrganizationApplianceVpnStatsAllAsync(
		this IApplianceVpnStats applianceVpnStats,
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		List<string>? networkIds = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, t0, t1, timespan, cancellationToken)
				=> applianceVpnStats.GetOrganizationApplianceVpnStatsApiResponseAsync(
					organizationId,
					startingAfter: startingAfter,
					endingBefore: endingBefore,
					networkIds: networkIds,
					t0: t0,
					t1: t1,
					timespan: timespan,
					cancellationToken: cancellationToken
				),
				t0,
				t1,
				timespan,
				cancellationToken
			);
}
