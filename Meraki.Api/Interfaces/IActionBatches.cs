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
	public interface IActionBatches
	{
		/// <summary>
		/// Create an action batch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="CreateOrganizationActionBatch">Body for creating organization action batch</param>
		[Post("/organizations/{organizationId}/actionBatches")]
		Task<ActionBatch> CreateAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] ActionBatchCreationRequest CreateOrganizationActionBatch,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete an action batch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="actionBatchId"></param>
		[Delete("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task DeleteAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("actionBatchId")] string actionBatchId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return an action batch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="actionBatchId">The action batch id</param>
		[Get("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task<ActionBatch> GetAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("actionBatchId")] string actionBatchId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the list of action batches in the organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="status">Filter batches by status. Valid types are pending, completed, and failed.</param>
		[Get("/organizations/{organizationId}/actionBatches")]
		Task<List<ActionBatch>> GetAllAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("status")] string? status = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update an action batch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="actionBatchId">The action batch id</param>
		/// <param name="UpdateOrganizationActionBatch">Body for updating organization action batch</param>
		[Put("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task<ActionBatch> UpdateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("actionBatchId")] string actionBatchId,
			[Body] ActionBatchUpdateRequest UpdateOrganizationActionBatch = null!,
			CancellationToken cancellationToken = default);
	}
}