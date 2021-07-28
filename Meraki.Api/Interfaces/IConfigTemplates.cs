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
	public interface IConfigurationTemplates
	{
		/// <summary>
		/// deleteOrganizationConfigTemplate
		/// </summary>
		/// <remarks>
		/// Remove a configuration template
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="configTemplateId"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
		Task DeleteAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("configTemplateId")]string configTemplateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationConfigTemplate
		/// </summary>
		/// <remarks>
		/// Return a single configuration template
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="configTemplateId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
		Task<ConfigurationTemplate> GetOrganizationConfigTemplate(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("configTemplateId")]string configTemplateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationConfigTemplates
		/// </summary>
		/// <remarks>
		/// List the configuration templates for this organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/configTemplates")]
		Task<List<ConfigurationTemplate>> GetAllAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateOrganizationConfigTemplate
		/// </summary>
		/// <remarks>
		/// Update a configuration template
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="configTemplateId"></param>
		/// <param name="updateOrganizationConfigTemplate"></param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
		Task<object> UpdateOrganizationConfigTemplateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[Body]ConfigurationTemplateUpdate updateOrganizationConfigTemplate,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// createOrganizationConfigTemplate
		/// </summary>
		/// <remarks>
		/// Create a new configuration template
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createOrganizationConfigTemplate"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/configTemplates")]
		Task<object> CreateOrganizationConfigTemplate(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[Body] ConfigurationTemplateUpdate createOrganizationConfigTemplate,
			CancellationToken cancellationToken = default);
	}
}
