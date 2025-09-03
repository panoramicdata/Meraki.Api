namespace Meraki.Api.Extensions;

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
