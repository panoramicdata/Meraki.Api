using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMonitoredMediaServers
	{
		/// <summary>
		/// createOrganizationInsightMonitoredMediaServer
		/// </summary>
		/// <remarks>
		/// Add a media server to be monitored for this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createOrganizationInsightMonitoredMediaServer"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/insight/monitoredMediaServers")]
		Task<object> CreateOrganizationInsightMonitoredMediaServer(
			[AliasAs("organizationId")]string organizationId,
			[Body]InsightMonitoredMediaServerCreationRequest createOrganizationInsightMonitoredMediaServer
			);

		/// <summary>
		/// deleteOrganizationInsightMonitoredMediaServer
		/// </summary>
		/// <remarks>
		/// Delete a monitored media server from this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="monitoredMediaServerId"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
		Task DeleteOrganizationInsightMonitoredMediaServer(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("monitoredMediaServerId")]string monitoredMediaServerId
			);

		/// <summary>
		/// getOrganizationInsightMonitoredMediaServer
		/// </summary>
		/// <remarks>
		/// Return a monitored media server for this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="monitoredMediaServerId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
		Task<InsightMonitoredMediaServers> GetOrganizationInsightMonitoredMediaServer(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("monitoredMediaServerId")]string monitoredMediaServerId
			);

		/// <summary>
		/// getOrganizationInsightMonitoredMediaServers
		/// </summary>
		/// <remarks>
		/// List the monitored media servers for this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/insight/monitoredMediaServers")]
		Task<List<InsightMonitoredMediaServers>> GetOrganizationInsightMonitoredMediaServers(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// updateOrganizationInsightMonitoredMediaServer
		/// </summary>
		/// <remarks>
		/// Update a monitored media server for this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="monitoredMediaServerId"></param>
		/// <param name="updateOrganizationInsightMonitoredMediaServer"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/insight/monitoredMediaServers/{monitoredMediaServerId}")]
		Task<object> UpdateOrganizationInsightMonitoredMediaServer(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("monitoredMediaServerId")]string monitoredMediaServerId,
			[Body]InsightMonitoredMediaServerUpdateRequest updateOrganizationInsightMonitoredMediaServer
			);
	}
}
