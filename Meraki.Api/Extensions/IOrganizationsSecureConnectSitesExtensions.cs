namespace Meraki.Api.Extensions;

public static class IOrganizationsSecureConnectSitesExtensions
{
	/// <summary>
	/// List all sites in this organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call.</exception>
	/// <param name="organizationsSecureConnectSites"></param>
	/// <param name="organizationId">The organization id.</param>
	/// <param name="cancellationToken">Cancellation token to cancel the request.</param>
	public static Task<List<SecureConnectSite>> GetOrganizationSecureConnectSitesAllAsync(
		this IOrganizationsSecureConnectSites organizationsSecureConnectSites,
		string organizationId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, endingBefore, cancellationToken)
			=> organizationsSecureConnectSites.GetOrganizationSecureConnectSitesApiResponseAsync(
				organizationId,
				startingAfter,
				endingBefore,
				cancellationToken
			),
			cancellationToken
		);
}
