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
	[ApiOperationId("getOrganizationAdaptivePolicyGroups")]
	[Get("/organizations/{organizationId}/adaptivePolicy/groups")]
	Task<List<AdaptivePolicyGroup>> GetOrganizationAdaptivePolicyGroupsAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);


	/// <summary>
	/// Creates a new adaptive policy group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationAdaptivePolicyGroup">New adaptive policy group</param>
	[ApiOperationId("createOrganizationAdaptivePolicyGroup")]
	[Post("/organizations/{organizationId}/adaptivePolicy/groups")]
	Task<AdaptivePolicyGroup> CreateOrganizationAdaptivePolicyGroupAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] AdaptivePolicyGroupCreate createOrganizationAdaptivePolicyGroup,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Returns an adaptive policy group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="groupId">The group id</param>
	[ApiOperationId("getOrganizationAdaptivePolicyGroup")]
	[Get("/organizations/{organizationId}/adaptivePolicy/groups/{groupId}")]
	Task<AdaptivePolicyGroup> GetOrganizationAdaptivePolicyGroupAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("groupId")] string groupId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Deletes the specified adaptive policy group and any associated policies and references
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="groupId">The group id</param>
	[ApiOperationId("deleteOrganizationAdaptivePolicyGroup")]
	[Delete("/organizations/{organizationId}/adaptivePolicy/groups/{groupId}")]
	Task DeleteOrganizationAdaptivePolicyGroupAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("groupId")] string groupId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates an adaptive policy group. If updating "Infrastructure", only the SGT is allowed. Cannot update "Unknown".
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="groupId">The group id</param>
	/// <param name="updateOrganizationAdaptivePolicyGroup">Body</param>
	[ApiOperationId("updateOrganizationAdaptivePolicyGroup")]
	[Put("/organizations/{organizationId}/adaptivePolicy/groups/{groupId}")]
	Task<AdaptivePolicyGroup> UpdateOrganizationAdaptivePolicyGroup(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("groupId")] string groupId,
		[Body] AdaptivePolicyGroupCreate updateOrganizationAdaptivePolicyGroup,
		CancellationToken cancellationToken = default);
}
