namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsAdaptivePolicyGroups
{
	/// <summary>
	/// List adaptive policy groups in a organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationAdaptivePolicyGroups")]
	[Get("/organizations/{organizationId}/adaptivePolicy/groups")]
	Task<List<AdaptivePolicyGroup>> GetOrganizationAdaptivePolicyGroupsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Creates a new adaptive policy group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationAdaptivePolicyGroup">New adaptive policy group</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createOrganizationAdaptivePolicyGroup")]
	[Post("/organizations/{organizationId}/adaptivePolicy/groups")]
	Task<AdaptivePolicyGroup> CreateOrganizationAdaptivePolicyGroupAsync(
		string organizationId,
		[Body] AdaptivePolicyGroupCreateUpdate createOrganizationAdaptivePolicyGroup,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Returns an adaptive policy group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The group id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationAdaptivePolicyGroup")]
	[Get("/organizations/{organizationId}/adaptivePolicy/groups/{id}")]
	Task<AdaptivePolicyGroup> GetOrganizationAdaptivePolicyGroupAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Deletes the specified adaptive policy group and any associated policies and references
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The group id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteOrganizationAdaptivePolicyGroup")]
	[Delete("/organizations/{organizationId}/adaptivePolicy/groups/{id}")]
	Task DeleteOrganizationAdaptivePolicyGroupAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates an adaptive policy group. If updating "Infrastructure", only the SGT is allowed. Cannot update "Unknown".
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The group id</param>
	/// <param name="updateOrganizationAdaptivePolicyGroup">Body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateOrganizationAdaptivePolicyGroup")]
	[Put("/organizations/{organizationId}/adaptivePolicy/groups/{id}")]
	Task<AdaptivePolicyGroup> UpdateOrganizationAdaptivePolicyGroupAsync(
		string organizationId,
		string id,
		[Body] AdaptivePolicyGroupCreateUpdate updateOrganizationAdaptivePolicyGroup,
		CancellationToken cancellationToken = default);
}
