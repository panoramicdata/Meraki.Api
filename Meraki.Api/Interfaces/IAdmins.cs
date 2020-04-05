using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Admins interface
	/// </summary>
	public interface IAdmins
	{
		/// <summary>
		/// createOrganizationAdmin
		/// </summary>
		/// <remarks>
		/// Create a new dashboard administrator
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createOrganizationAdmin"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/admins")]
		Task<Admin> CreateAsync(
			[AliasAs("organizationId")]string organizationId,
			[Body]AdminCreationRequest createOrganizationAdmin,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteOrganizationAdmin
		/// </summary>
		/// <remarks>
		/// Revoke all access for a dashboard administrator within this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="id"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/admins/{id}")]
		Task DeleteAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("id")]string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationAdmins
		/// </summary>
		/// <remarks>
		/// List the dashboard administrators in this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/admins")]
		Task<List<Admin>> GetAllAsync(
			[AliasAs("organizationId")]string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateOrganizationAdmin
		/// </summary>
		/// <remarks>
		/// Update an administrator
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="id"></param>
		/// <param name="updateOrganizationAdmin"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/admins/{id}")]
		Task<Admin> UpdateAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("id")]string id,
			[Body]UpdateOrganizationAdmin updateOrganizationAdmin,
			CancellationToken cancellationToken = default);
	}
}
