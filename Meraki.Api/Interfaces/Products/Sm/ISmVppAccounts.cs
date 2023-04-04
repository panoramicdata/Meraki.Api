namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISmVppAccounts
{
	/// <summary>
	/// List the VPP accounts in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/sm/vppAccounts")]
	Task<List<SmVppAccount>> GetOrganizationSmVppAccountsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the VPP accounts in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="vppAccountId">The VPP account id</param>
	[Get("/organizations/{organizationId}/sm/vppAccounts/{vppAccountId}")]
	Task<SmVppAccount> GetOrganizationSmVppAccountAsync(
		string organizationId,
		string vppAccountId,
		CancellationToken cancellationToken = default);
}
