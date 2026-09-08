namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IOrganizations Assurance
/// </summary>

public static class IOrganizationsAssuranceExtensions
{
	/// <summary>
	/// Return all health alerts for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<OrganizationAssuranceAlert>> GetOrganizationAssuranceAlertsAllAsync(
		this IOrganizationsAssuranceAlerts organizationAssuranceAlerts,
		string organizationId,
		string? sortOrder,
		string? networkId,
		string? severity,
		List<string>? types,
		string? tsStart,
		string? tsEnd,
		string? category,
		string? sortBy,
		List<string>? serials,
		List<string>? deviceTypes,
		List<string>? deviceTags,
		bool? active,
		bool? dismissed,
		bool? resolved,
		bool? suppressAlertsForOfflineNodes,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> organizationAssuranceAlerts.GetOrganizationAssuranceAlertsApiResponseAsync(
						organizationId,
						startingAfter,
						endingBefore,
						sortOrder,
						networkId,
						severity,
						types,
						tsStart,
						tsEnd,
						category,
						sortBy,
						serials,
						deviceTypes,
						deviceTags,
						active,
						dismissed,
						resolved,
						suppressAlertsForOfflineNodes,
						cancellationToken
					),
					cancellationToken
			);
}
