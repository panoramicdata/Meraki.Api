using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDashboardBrandingPolicies
	{
		/// <summary>
		/// Return a branding policy
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="brandingPolicyId">The branding policy id</param>
		[Get("/organizations/{organizationId}/brandingPolicies/{brandingPolicyId}")]
		Task<BrandingPolicy> GetAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("brandingPolicyId")] string brandingPolicyId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the branding policies of an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/brandingPolicies")]
		Task<List<BrandingPolicy>> GetAllAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Add a new branding policy to an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="brandingPolicy">Body for creating an organization's branding policy</param>
		[Post("/organizations/{organizationId}/brandingPolicies")]
		Task<BrandingPolicy> CreateAsync(
			[AliasAs("organizationId")] string organizationId,
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
		Task<BrandingPolicy> UpdateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("brandingPolicyId")] string brandingPolicyId,
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
		Task DeleteAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("brandingPolicyId")] string brandingPolicyId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the branding policy IDs of an organization in priority order
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/brandingPolicies/priorities")]
		Task<BrandingPoliciesPriorities> GetPrioritiesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the priority ordering of an organization&#39;s branding policies.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="brandingPoliciesPriorities">Body for updating an organization branding policies priorities</param>
		[Put("/organizations/{organizationId}/brandingPolicies/priorities")]
		Task<BrandingPoliciesPriorities> UpdatePrioritiesAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] BrandingPoliciesPriorities brandingPoliciesPriorities,
			CancellationToken cancellationToken = default
			);
	}
}
