namespace Meraki.Api.Extensions;

public static class IApplianceVpnStatusesExtensions
{
	/// <summary>
	/// Show all VPN statuses for networks in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkIds">A list of Meraki network IDs to filter results to contain only specified networks. E.g.: networkIds[]=N_12345678&networkIds[]=L_3456</param>
	public static Task<List<VpnStatus>> GetOrganizationApplianceVpnStatusesAllAsync(
		this IApplianceVpnStatuses organizationInventoryDevices,
		string organizationId,
		List<string>? networkIds = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, cancellationToken)
			=> organizationInventoryDevices.GetOrganizationApplianceVpnStatusesApiResponseAsync(
				organizationId,
				startingAfter,
				networkIds,
				cancellationToken
			),
			cancellationToken
		);
}
