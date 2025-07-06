namespace Meraki.Api.Interfaces.Products.Insight;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IInsightMonitoredMediaServers
{
	/// <summary>
	/// List the monitored media servers for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/insight/monitoredMediaServers")]
	Task<List<InsightMonitoredMediaServer>> GetOrganizationInsightMonitoredMediaServersAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a media server to be monitored for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationInsightMonitoredMediaServer">Body for adding a media server</param>
	/// <param name="cancellationToken"></param>
	[Post("/organizations/{organizationId}/insight/monitoredMediaServers")]
	Task<InsightMonitoredMediaServer> CreateOrganizationInsightMonitoredMediaServerAsync(
		string organizationId,
		[Body] InsightMonitoredMediaServerCreationRequest createOrganizationInsightMonitoredMediaServer,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a monitored media server for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="monitoredMediaServerId">The monitored media server id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
	Task<InsightMonitoredMediaServer> GetOrganizationInsightMonitoredMediaServerAsync(
		string organizationId,
		string monitoredMediaServerId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a monitored media server for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="monitoredMediaServerId">The monitored media server id</param>
	/// <param name="updateOrganizationInsightMonitoredMediaServer">Body for updating a monitored media server</param>
	/// <param name="cancellationToken"></param>
	[Put("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
	Task<InsightMonitoredMediaServer> UpdateOrganizationInsightMonitoredMediaServerAsync(
		string organizationId,
		string monitoredMediaServerId,
		[Body] InsightMonitoredMediaServerUpdateRequest updateOrganizationInsightMonitoredMediaServer,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a monitored media server from this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="monitoredMediaServerId">The monitored media server id</param>
	/// <param name="cancellationToken"></param>
	[Delete("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
	Task DeleteOrganizationInsightMonitoredMediaServerAsync(
		string organizationId,
		string monitoredMediaServerId,
		CancellationToken cancellationToken = default
		);
}
