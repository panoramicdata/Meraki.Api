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
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="configTemplateId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switchProfiles")]
		Task<List<SwitchProfile>> GetAllAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("configTemplateId")]string configTemplateId,
			CancellationToken cancellationToken = default);
	}
}
