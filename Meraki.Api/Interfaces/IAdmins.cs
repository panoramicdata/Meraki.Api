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
		/// Create a new dashboard administrator
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="createOrganizationAdmin"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/admins")]
		Task<Admin> CreateAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] AdminCreationRequest createOrganizationAdmin,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteOrganizationAdmin
		/// </summary>
		/// <remarks>
		/// Revoke all access for a dashboard administrator within this organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="id"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/admins/{id}")]
		Task DeleteAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		///	Get Organization Admins
		/// </summary>
		/// <remarks>
		///	List the dashboard administrators in this organization.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <returns>The list of Admins</returns>
		[Get("/organizations/{organizationId}/admins")]
		Task<List<Admin>> GetAllAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Organization Admin
		/// </summary>
		/// <remarks>
		/// Update an administrator
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="id">The Admin id</param>
		/// <param name="adminUpdateRequest"></param>
		/// <returns>The updated Admin</returns>
		[Put("/organizations/{organizationId}/admins/{id}")]
		Task<Admin> UpdateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("id")] string id,
			[Body] AdminUpdateRequest adminUpdateRequest,
			CancellationToken cancellationToken = default);
	}
}
