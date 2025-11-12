namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Policy Objects Groups
/// </summary>
public interface IOrganizationsPolicyObjectsGroups
{
	/// <summary>
	/// Shows details of a Policy Object Group.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="policyObjectGroupId">The policy object id</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	[Get("/organizations/{organizationId}/policyObjects/groups/{policyObjectGroupId}")]
	[ApiOperationId("getOrganizationPolicyObjectsGroup")]
	Task<OrganizationPolicyObjectsGroup> GetOrganizationPolicyObjectsGroupAsync(
		string organizationId,
		string policyObjectGroupId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Lists Policy Object Groups belonging to the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">TThe number of entries per page returned. Acceptable range is 10 - 5000. Default is 5000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>",
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	[Get("/organizations/{organizationId}/policyObjects/groups")]
	[ApiOperationId("getOrganizationPolicyObjectsGroups")]
	Task<List<OrganizationPolicyObjectsGroup>> GetOrganizationPolicyObjectsGroupsAsync(
		string organizationId,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default
		);

	// Used by IOrganizationsPolicyObjectsGroupsExtentions.GetOrganizationPolicyObjectsGroupsAllAsync
	[Get("/organizations/{organizationId}/policyObjects/groups")]
	internal Task<ApiResponse<List<OrganizationPolicyObjectsGroup>>> GetOrganizationPolicyObjectsGroupsApiResponseAsync(
		string organizationId,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Creates a new Policy Objects Group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="organizationPolicyObjectsGroupCreateRequest">The body for the creation request</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	[Post("/organizations/{organizationId}/policyObjects/groups")]
	[ApiOperationId("createOrganizationPolicyObjectsGroup")]
	Task<OrganizationPolicyObjectsGroup> CreateOrganizationPolicyObjectsGroupAsync(
		string organizationId,
		[Body] OrganizationPolicyObjectsGroupCreateRequest organizationPolicyObjectsGroupCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update Organization Policy Objects Group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="policyObjectGroupId">The id of the policy objects group</param>
	/// <param name="organizationPolicyObjectsGroupUpdateRequest">The body for the update request</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	[Put("/organizations/{organizationId}/policyObjects/groups/{policyObjectGroupId}")]
	[ApiOperationId("updateOrganizationPolicyObjectsGroup")]
	Task<OrganizationPolicyObjectsGroup> UpdateOrganizationPolicyObjectsGroupAsync(
		string organizationId,
		string policyObjectGroupId,
		[Body] OrganizationPolicyObjectsGroupUpdateRequest organizationPolicyObjectsGroupUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Deletes a Policy Object
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="policyObjectGroupId">The policy object id</param>
	/// <param name="cancellationToken"></param>
	[Delete("/organizations/{organizationId}/policyObjects/groups/{policyObjectGroupId}")]
	[ApiOperationId("deleteOrganizationPolicyObjectsGroup")]
	Task DeleteOrganizationPolicyObjectsGroupAsync(
		string organizationId,
		string policyObjectGroupId,
		CancellationToken cancellationToken = default);
}
