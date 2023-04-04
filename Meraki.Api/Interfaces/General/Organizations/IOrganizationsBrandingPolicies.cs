namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsBrandingPolicies
{
	/// <summary>
	/// List the branding policies of an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/brandingPolicies")]
	Task<List<BrandingPolicy>> GetOrganizationBrandingPoliciesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a branding policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="brandingPolicyId">The branding policy id</param>
	[Get("/organizations/{organizationId}/brandingPolicies/{brandingPolicyId}")]
	Task<BrandingPolicy> GetOrganizationBrandingPolicyAsync(
		string organizationId,
		string brandingPolicyId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a new branding policy to an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="brandingPolicy">Body for creating an organization's branding policy</param>
	[Post("/organizations/{organizationId}/brandingPolicies")]
	Task<BrandingPolicy> CreateOrganizationBrandingPolicyAsync(
		string organizationId,
		[Body] BrandingPolicy brandingPolicy,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a branding policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="brandingPolicyId"></param>
	/// <param name="brandingPolicy">Body for updating an organization's branding policy</param>
	[Put("/organizations/{organizationId}/brandingPolicies/{brandingPolicyId}")]
	Task<BrandingPolicy> UpdateOrganizationBrandingPolicyAsync(
		string organizationId,
		string brandingPolicyId,
		[Body] BrandingPolicy brandingPolicy,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a branding policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="brandingPolicyId">The branding policy id</param>
	[Delete("/organizations/{organizationId}/brandingPolicies/{brandingPolicyId}")]
	Task DeleteOrganizationBrandingPolicyAsync(
		string organizationId,
		string brandingPolicyId,
		CancellationToken cancellationToken = default
		);
}
