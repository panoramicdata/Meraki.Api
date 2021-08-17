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
	public interface ISwitchProfiles
	{
		/// <summary>
		/// List the switch profiles for your switch template configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">The configuration id</param>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switchProfiles")]
		Task<List<SwitchProfile>> GetAllAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("configTemplateId")]string configTemplateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return all the ports of a switch profile
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">The configuration id</param>
		/// <param name="profileId">The profile id</param>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports")]
		Task<List<ConfigTemplateSwitchProfilePorts>> GetOrganizationConfigTemplateSwitchProfilePortsAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[AliasAs("profileId")] string profileId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a switch profile port
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">The configuration id</param>
		/// <param name="profileId">The profile id</param>
		/// <param name="portId">The port id</param>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports/{portId}")]
		Task<ConfigTemplateSwitchProfilePorts> GetOrganizationConfigTemplateSwitchProfilePortAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[AliasAs("profileId")] string profileId,
			[AliasAs("portId")] string portId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a switch profile port
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">The configuration id</param>
		/// <param name="profileId">The profile id</param>
		/// <param name="portId">The port id</param>
		/// <param name="UpdateOrganizationConfigTemplateSwitchProfilePort"></param>
		[Put("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports/{portId}")]
		Task<ConfigTemplateSwitchProfilePorts> UpdateOrganizationConfigTemplateSwitchProfilePortAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[AliasAs("profileId")] string profileId,
			[AliasAs("portId")] string portId,
			[Body]ConfigTemplateSwitchProfilePorts UpdateOrganizationConfigTemplateSwitchProfilePort,
			CancellationToken cancellationToken = default
			);
	}
}
