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
		/// getOrganizationConfigTemplateSwitchProfiles
		/// </summary>
		/// <remarks>
		/// List the switch profiles for your switch template configuration
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="configTemplateId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switchProfiles")]
		Task<List<SwitchProfile>> GetAllAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("configTemplateId")]string configTemplateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationConfigTemplateSwitchProfilePorts
		/// </summary>
		/// <remarks>
		/// Return all the ports of a switch profile
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="configTemplateId"></param>
		/// <param name="profileId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports")]
		Task<List<ConfigTemplateSwitchProfilePorts>> GetOrganizationConfigTemplateSwitchProfilePorts(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[AliasAs("profileId")] string profileId
			);

		/// <summary>
		/// getOrganizationConfigTemplateSwitchProfilePort
		/// </summary>
		/// <remarks>
		/// Return a switch profile port
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="configTemplateId"></param>
		/// <param name="profileId"></param>
		/// <param name="portId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports/{portId}")]
		Task<ConfigTemplateSwitchProfilePorts> GetOrganizationConfigTemplateSwitchProfilePort(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[AliasAs("profileId")] string profileId,
			[AliasAs("portId")] string portId
			);

		/// <summary>
		/// updateOrganizationConfigTemplateSwitchProfilePort
		/// </summary>
		/// <remarks>
		/// Update a switch profile port
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="configTemplateId"></param>
		/// <param name="profileId"></param>
		/// <param name="portId"></param>
		/// <param name="updateOrganizationConfigTemplateSwitchProfilePort"></param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports/{portId}")]
		Task<object> UpdateOrganizationConfigTemplateSwitchProfilePort(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[AliasAs("profileId")] string profileId,
			[AliasAs("portId")] string portId,
			[Body]ConfigTemplateSwitchProfilePorts updateOrganizationConfigTemplateSwitchProfilePort
			);
	}
}
