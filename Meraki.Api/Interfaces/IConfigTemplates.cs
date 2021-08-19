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
		/// Remove a configuration template
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">The config template id</param>
		[Delete("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
		Task DeleteAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a single configuration template
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">The config template id</param>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
		Task<ConfigurationTemplate> GetOrganizationConfigTemplateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the configuration templates for this organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/configTemplates")]
		Task<List<ConfigurationTemplate>> GetAllAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update a configuration template
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">The config template id</param>
		/// <param name="UpdateOrganizationConfigTemplate">Body for updating an organization's config template</param>
		[Put("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
		Task<ConfigurationTemplate> UpdateOrganizationConfigTemplateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[Body] ConfigurationTemplateUpdate UpdateOrganizationConfigTemplate,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a new configuration template
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="CreateOrganizationConfigTemplate">The config template id</param>
		[Post("/organizations/{organizationId}/configTemplates")]
		Task<ConfigurationTemplateUpdate> CreateOrganizationConfigTemplateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[Body] ConfigurationTemplateUpdate CreateOrganizationConfigTemplate,
			CancellationToken cancellationToken = default);
	}
}
