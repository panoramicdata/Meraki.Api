namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsAdaptivePolicyPolicies
{
	/// <summary>
	/// List adaptive policies in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationAdaptivePolicyPolicies")]
	[Get("/organizations/{organizationId}/adaptivePolicy/policies")]
	Task<List<AdaptivePolicyPolicies>> GetOrganizationAdaptivePolicyPoliciesAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Add an Adaptive Policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationAdaptivePolicyPolicy">Body</param>
	[ApiOperationId("createOrganizationAdaptivePolicyPolicy")]
	[Post("/organizations/{organizationId}/adaptivePolicy/policies")]
	Task<AdaptivePolicyPolicies> CreateOrganizationAdaptivePolicyPolicyAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] AdaptivePolicyPolicyCreate createOrganizationAdaptivePolicyPolicy,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an adaptive policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="adaptivePolicyId">The adaptive policy id</param>
	[ApiOperationId("getOrganizationAdaptivePolicyPolicy")]
	[Get("/organizations/{organizationId}/adaptivePolicy/policies/{adaptivePolicyId}")]
	Task<AdaptivePolicyPolicies> GetOrganizationAdaptivePolicyPolicyAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("adaptivePolicyId")] string adaptivePolicyId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an Adaptive Policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="adaptivePolicyId">The adaptive policy id</param>
	/// <param name="updateOrganizationAdaptivePolicyPolicy">Body</param>
	[ApiOperationId("updateOrganizationAdaptivePolicyPolicy")]
	[Put("/organizations/{organizationId}/adaptivePolicy/policies/{adaptivePolicyId}")]
	Task<AdaptivePolicyPolicies> UpdateOrganizationAdaptivePolicyPolicyAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("adaptivePolicyId")] string adaptivePolicyId,
		[Body] AdaptivePolicyPolicyCreate updateOrganizationAdaptivePolicyPolicy,
		CancellationToken cancellationToken = default);
}