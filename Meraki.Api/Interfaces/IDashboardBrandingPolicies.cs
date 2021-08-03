using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDashboardBrandingPolicies
	{
		/// <summary>
		/// createOrganizationBrandingPolicy
		/// </summary>
		/// <remarks>
		/// Add a new branding policy to an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createOrganizationBrandingPolicy"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/brandingPolicies")]
		Task<object> CreateOrganizationBrandingPolicy(
			[AliasAs("organizationId")]string organizationId,
			[Body]BrandingPolicyCreationRequest createOrganizationBrandingPolicy
			);

		/// <summary>
		/// deleteOrganizationBrandingPolicy
		/// </summary>
		/// <remarks>
		/// Delete a branding policy
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="brandingPolicyId"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/brandingPolicies/{brandingPolicyId}")]
		Task DeleteOrganizationBrandingPolicy(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("brandingPolicyId")]string brandingPolicyId
			);

		/// <summary>
		/// getOrganizationBrandingPolicies
		/// </summary>
		/// <remarks>
		/// List the branding policies of an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/brandingPolicies")]
		Task<object> GetOrganizationBrandingPolicies(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// getOrganizationBrandingPoliciesPriorities
		/// </summary>
		/// <remarks>
		/// Return the branding policy IDs of an organization in priority order
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/brandingPolicies/priorities")]
		Task<object> GetOrganizationBrandingPoliciesPriorities(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// getOrganizationBrandingPolicy
		/// </summary>
		/// <remarks>
		/// Return a branding policy
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="brandingPolicyId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/brandingPolicies/{brandingPolicyId}")]
		Task<object> GetOrganizationBrandingPolicy(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("brandingPolicyId")]string brandingPolicyId
			);

		/// <summary>
		/// updateOrganizationBrandingPoliciesPriorities
		/// </summary>
		/// <remarks>
		/// Update the priority ordering of an organization&#39;s branding policies.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="updateOrganizationBrandingPoliciesPriorities"></param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/brandingPolicies/priorities")]
		Task<object> UpdateOrganizationBrandingPoliciesPriorities(
			[AliasAs("organizationId")]string organizationId,
			[Body]BrandingPoliciesPrioritiesUpdateRequest updateOrganizationBrandingPoliciesPriorities
			);

		/// <summary>
		/// updateOrganizationBrandingPolicy
		/// </summary>
		/// <remarks>
		/// Update a branding policy
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="brandingPolicyId"></param>
		/// <param name="updateOrganizationBrandingPolicy"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/brandingPolicies/{brandingPolicyId}")]
		Task<object> UpdateOrganizationBrandingPolicy(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("brandingPolicyId")]string brandingPolicyId,
			[Body]BrandingPolicyUpdateRequest updateOrganizationBrandingPolicy
			);
	}
}
