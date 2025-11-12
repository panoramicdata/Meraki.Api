namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Policy Objects
/// </summary>
public interface IOrganizationsPolicyObjects
{
	/// <summary>
	/// Shows details of a Policy Object.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="policyObjectId">The policy object id</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	[Get("/organizations/{organizationId}/policyObjects/{policyObjectId}")]
	Task<OrganizationPolicyObject> GetOrganizationPolicyObjectAsync(
		string organizationId,
		string policyObjectId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Lists Policy Objects belonging to the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">TThe number of entries per page returned. Acceptable range is 10 - 5000. Default is 5000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>",
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	[Get("/organizations/{organizationId}/policyObjects")]
	Task<List<OrganizationPolicyObject>> GetOrganizationPolicyObjectsAsync(
		string organizationId,
		int? perPage = 5000,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default
		);

	// Used by IOrganizationsPolicyObjectsExtentions.GetOrganizationPolicyObjectsAllAsync
	[Get("/organizations/{organizationId}/policyObjects")]
	internal Task<ApiResponse<List<OrganizationPolicyObject>>> GetOrganizationPolicyObjectsApiResponseAsync(
		string organizationId,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Creates a new Policy Object.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="organizationPolicyObjectCreateRequest">The body for the creation request</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	[Post("/organizations/{organizationId}/policyObjects")]
	Task<OrganizationPolicyObject> CreateOrganizationPolicyObjectAsync(
		string organizationId,
		[Body] OrganizationPolicyObjectCreateRequest organizationPolicyObjectCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates a Policy Object.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="policyObjectId">The id of the policy object</param>
	/// <param name="organizationPolicyObjectUpdateRequest">The body for the update request</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	[Put("/organizations/{organizationId}/policyObjects/{policyObjectId}")]
	Task<OrganizationPolicyObject> UpdateOrganizationPolicyObjectAsync(
		string organizationId,
		string policyObjectId,
		[Body] OrganizationPolicyObjectUpdateRequest organizationPolicyObjectUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Deletes a Policy Object
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="policyObjectId">The policy object id</param>
	/// <param name="cancellationToken"></param>
	[Delete("/organizations/{organizationId}/policyObjects/{policyObjectId}")]
	Task DeleteOrganizationPolicyObjectAsync(
		string organizationId,
		string policyObjectId,
		CancellationToken cancellationToken = default);
}
