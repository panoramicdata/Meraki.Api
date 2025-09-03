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
		long organizationId,
		int? page,
		string? limit,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a destination list in your organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="secureConnectDestinationListCreateRequest">Destination list to create.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("createDestinationList")]
	[Post("/organizations/{organizationId}/policy/destinationLists")]
	Task<SecureConnectDestinationListResponse> CreateDestinationListAsync(
		long organizationId,
		[Body] SecureConnectDestinationListCreateRequest secureConnectDestinationListCreateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a destination list in your organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="destinationListId">The unique ID of the destination list.</param>
	/// <param name="secureConnectDestinationListUpdateRequest">Destination list update request.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("updateDestinationLists")]
	[Patch("/organizations/{organizationId}/policy/destinationLists/{destinationListId}")]
	Task<SecureConnectDestinationListResponse> UpdateDestinationListsAsync(
		long organizationId,
		int destinationListId,
		[Body] SecureConnectDestinationListUpdateRequest secureConnectDestinationListUpdateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a destination list from your organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="destinationListId">The unique ID of the destination list.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("deleteDestinationList")]
	[Delete("/organizations/{organizationId}/policy/destinationLists/{destinationListId}")]
	Task DeleteDestinationListAsync(
		long organizationId,
		int destinationListId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get a destination list.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="destinationListId">The unique ID of the destination list.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("getDestinationList")]
	[Get("/organizations/{organizationId}/policy/destinationLists/{destinationListId}")]
	Task<SecureConnectDestinationListResponse> GetDestinationListAsync(
		long organizationId,
		int destinationListId,
		CancellationToken cancellationToken = default);
}