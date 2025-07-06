namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchProfiles
{
	/// <summary>
	/// List the switch templates for your switch template configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">The configuration id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles")]
	Task<List<SwitchProfile>> GetOrganizationConfigTemplateSwitchProfilesAsync(
		string organizationId,
		string configTemplateId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return all the templates of a switch profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">The configuration id</param>
	/// <param name="profileId">The profile id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports")]
	Task<List<ConfigTemplateSwitchProfilePort>> GetOrganizationConfigTemplateSwitchProfilePortsAsync(
		string organizationId,
		string configTemplateId,
		string profileId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a switch template port
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">The configuration id</param>
	/// <param name="profileId">The profile id</param>
	/// <param name="portId">The port id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports/{portId}")]
	Task<ConfigTemplateSwitchProfilePort> GetOrganizationConfigTemplateSwitchProfilePortAsync(
		string organizationId,
		string configTemplateId,
		string profileId,
		string portId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a switch template port
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">The configuration id</param>
	/// <param name="profileId">The profile id</param>
	/// <param name="portId">The port id</param>
	/// <param name="updateOrganizationConfigTemplateSwitchProfilePort"></param>
	/// <param name="cancellationToken"></param>
	[Put("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports/{portId}")]
	Task<ConfigTemplateSwitchProfilePort> UpdateOrganizationConfigTemplateSwitchProfilePortAsync(
		string organizationId,
		string configTemplateId,
		string profileId,
		string portId,
		[Body] ConfigTemplateSwitchProfilePort updateOrganizationConfigTemplateSwitchProfilePort,
		CancellationToken cancellationToken = default
		);
}
