namespace Meraki.Api.Interfaces.SecureConnect.Policies;
public interface ISecureConnectPoliciesDestinationLists
{
	/// <summary>
	/// Get the destination lists in your organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="page">The number of a page in the collection.</param>
	/// <param name="limit">The number of records in the collection to return on the page. example = 50, default = 100, minimum = 1, maximum = 100</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("getDestinationLists")]
	[Get("/organizations/{organizationId}/policy/destinationLists")]
	Task<SecureConnectDestinationLists> GetDestinationListsAsync(
		string organizationId,
		int? page,
		string? limit,
		CancellationToken cancellationToken = default);
}