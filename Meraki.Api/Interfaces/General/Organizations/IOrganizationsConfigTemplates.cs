namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsConfigTemplates
{
	/// <summary>
	/// List the configuration templates for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/configTemplates")]
	Task<List<ConfigurationTemplate>> GetOrganizationConfigTemplatesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a single configuration template
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">The config template id</param>
	[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
	Task<ConfigurationTemplate> GetOrganizationConfigTemplateAsync(
		string organizationId,
		string configTemplateId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Remove a configuration template
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">The config template id</param>
	[Delete("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
	Task DeleteOrganizationConfigTemplateAsync(
		string organizationId,
		string configTemplateId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a configuration template
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">The config template id</param>
	/// <param name="updateOrganizationConfigTemplate">Body for updating an organization's config template</param>
	[Put("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
	Task<ConfigurationTemplate> UpdateOrganizationConfigTemplateAsync(
		string organizationId,
		string configTemplateId,
		[Body] ConfigurationTemplateUpdate updateOrganizationConfigTemplate,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a new configuration template
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationConfigTemplate">The config template data</param>
	[Post("/organizations/{organizationId}/configTemplates")]
	Task<ConfigurationTemplate> CreateOrganizationConfigTemplateAsync(
		string organizationId,
		[Body] ConfigurationTemplateCreateRequest createOrganizationConfigTemplate,
		CancellationToken cancellationToken = default);
}
