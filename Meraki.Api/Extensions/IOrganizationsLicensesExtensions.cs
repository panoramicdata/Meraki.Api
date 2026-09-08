namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IOrganizations Licenses
/// </summary>

public static class IOrganizationsLicensesExtensions
{
	/// <summary>
	/// List the licenses for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationsLicenses"></param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="deviceSerial">Filter the licenses to those assigned to a particular device (optional)</param>
	/// <param name="networkId">Filter the licenses to those assigned in a particular network (optional)</param>
	/// <param name="state">Filter the licenses to those in a particular state. Can be one of 'active', 'expired', 'expiring', 'unused', 'unusedActive' or 'recentlyQueued' (optional)</param>
	/// <param name="cancellationToken"></param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<OrganizationLicense>> GetOrganizationLicensesAllAsync(
		this IOrganizationsLicenses organizationsLicenses,
		string organizationId,
		string? deviceSerial = null,
		string? networkId = null,
		string? state = null,
		CancellationToken cancellationToken = default)
			=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> organizationsLicenses.GetPagedApiResponseAsync(
					organizationId,
					startingAfter,
					endingBefore,
					deviceSerial,
					networkId,
					state,
					cancellationToken)
				, cancellationToken
				);
}
