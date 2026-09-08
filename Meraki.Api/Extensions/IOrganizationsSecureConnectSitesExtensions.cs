namespace Meraki.Api.Extensions;
/// <summary>
/// Extension methods for <see cref="IOrganizationsSecureConnectSites"/> to provide additional functionality for working with Secure Connect Sites in an organization.
/// </summary>
public static class IOrganizationsSecureConnectSitesExtensions
{
	/// <summary>
	/// Get all networks that the user has privileges on in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationsSecureConnectSites"></param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="search">If provided, filters results by search string</param>
	/// <param name="enrolledState">Filter results by sites that have already been enrolled or can be enrolled. Acceptable values are 'enrolled' or 'enrollable'</param>
	/// <param name="pageSize"></param>
	/// <param name="cancellationToken"></param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<SecureConnectSite>> GetOrganizationSecureConnectSitesAllAsync(
		this IOrganizationsSecureConnectSites organizationsSecureConnectSites,
		string organizationId,
		string? search = null,
		string? enrolledState = null,
		int? pageSize = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllFromResponsePropertyAsync(
				(startingAfter, endingBefore, cancellationToken) =>
					organizationsSecureConnectSites.GetOrganizationSecureConnectSitesApiResponseAsync(
						organizationId,
						pageSize ?? 1000,
						startingAfter,
						endingBefore,
						search,
						enrolledState,
						cancellationToken
					),
				(response) => response.Content?.Data ?? [],
				cancellationToken
			);
}
