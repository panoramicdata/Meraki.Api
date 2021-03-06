using Meraki.Api.Data;
using Refit;
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
		/// createOrganizationActionBatch
		/// </summary>
		/// <remarks>
		/// Create an action batch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createOrganizationActionBatch"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/actionBatches")]
		Task<object> CreateAsync(
			[AliasAs("organizationId")]string organizationId,
			[Body]ActionBatchCreationRequest createOrganizationActionBatch,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteOrganizationActionBatch
		/// </summary>
		/// <remarks>
		/// Delete an action batch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="actionBatchId"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task DeleteAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("actionBatchId")]string actionBatchId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationActionBatch
		/// </summary>
		/// <remarks>
		/// Return an action batch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="actionBatchId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task<object> GetAsync(

			[AliasAs("organizationId")]string organizationId,
			[AliasAs("actionBatchId")]string actionBatchId
			);

		/// <summary>
		/// getOrganizationActionBatches
		/// </summary>
		/// <remarks>
		/// Return the list of action batches in the organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/actionBatches")]
		Task<object> GetAllAsync(
			[AliasAs("organizationId")]string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateOrganizationActionBatch
		/// </summary>
		/// <remarks>
		/// Update an action batch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="actionBatchId"></param>
		/// <param name="updateOrganizationActionBatch"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task<object> UpdateAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("actionBatchId")]string actionBatchId,
			[Body]ActionBatchUpdateRequest updateOrganizationActionBatch = null!,
			CancellationToken cancellationToken = default);
	}
}