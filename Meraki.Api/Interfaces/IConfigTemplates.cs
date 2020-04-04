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
			[AliasAs("organizationId")]string organizationId,
			CancellationToken cancellationToken = default);
	}
}
