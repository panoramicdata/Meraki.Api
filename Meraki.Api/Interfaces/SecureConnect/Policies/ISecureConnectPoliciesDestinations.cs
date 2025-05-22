namespace Meraki.Api.Interfaces.SecureConnect.Policies;

public interface ISecureConnectPoliciesDestinations
{
	/// <summary>
	/// Get destinations in a destination list.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="destinationListId">The unique ID of the destination list.</param>
	/// <param name="page">The number of a page in the collection.</param>
	/// <param name="limit">The number of records in the collection to return on the page.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("getDestinations")]
	[Get("/organizations/{organizationId}/policy/destinationLists/{destinationListId}/destinations")]
	Task<SecureConnectDestinations> GetDestinationsAsync(
		string organizationId,
		int destinationListId,
		int page,
		int limit,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Add destinations to a destination list.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="destinationListId">The unique ID of the destination list.</param>
	/// <param name="SecureConnectionDestinationCreateRequest">The destinations creation request</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("createDestinations")]
	[Post("/organizations/{organizationId}/policy/destinationLists/{destinationListId}/destinations")]
	Task<SecureConnectionDestinationsResponse> CreateDestinationsAsync(
		string organizationId,
		int destinationListId,
		[Body] SecureConnectionDestinationCreateRequest SecureConnectionDestinationCreateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Remove destinations from the destination list.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="destinationListId">The unique ID of the destination list.</param>
	/// <param name="SecureConnectionDestinationsDeleteRequest">The list of destination ID.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("deleteDestinations")]
	[Delete("/organizations/{organizationId}/policy/destinationLists/{destinationListId}/destinations/remove")]
	Task<SecureConnectionDestinationsResponse> DeleteDestinationsAsync(
		string organizationId,
		int destinationListId,
		[Body] List<int> SecureConnectionDestinationsDeleteRequest,
		CancellationToken cancellationToken = default);
}
