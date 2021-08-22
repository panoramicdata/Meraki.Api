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
	public interface IMonitoredMediaServers
	{
		/// <summary>
		/// Add a media server to be monitored for this organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="createOrganizationInsightMonitoredMediaServer">Body for adding a media server</param>
		[Post("/organizations/{organizationId}/insight/monitoredMediaServers")]
		Task<InsightMonitoredMediaServers> CreateOrganizationInsightMonitoredMediaServerAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] InsightMonitoredMediaServerCreationRequest createOrganizationInsightMonitoredMediaServer,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a monitored media server from this organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="monitoredMediaServerId">The monitored media server id</param>
		[Delete("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
		Task DeleteOrganizationInsightMonitoredMediaServerAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("monitoredMediaServerId")] string monitoredMediaServerId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a monitored media server for this organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="monitoredMediaServerId">The monitored media server id</param>
		[Get("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
		Task<InsightMonitoredMediaServers> GetOrganizationInsightMonitoredMediaServerAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("monitoredMediaServerId")] string monitoredMediaServerId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the monitored media servers for this organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/insight/monitoredMediaServers")]
		Task<List<InsightMonitoredMediaServers>> GetOrganizationInsightMonitoredMediaServersAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a monitored media server for this organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="monitoredMediaServerId">The monitored media server id</param>
		/// <param name="updateOrganizationInsightMonitoredMediaServer">Body for updating a monitored media server</param>
		[Put("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
		Task<InsightMonitoredMediaServers> UpdateOrganizationInsightMonitoredMediaServerAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("monitoredMediaServerId")] string monitoredMediaServerId,
			[Body] InsightMonitoredMediaServerUpdateRequest updateOrganizationInsightMonitoredMediaServer,
			CancellationToken cancellationToken = default
			);
	}
}
