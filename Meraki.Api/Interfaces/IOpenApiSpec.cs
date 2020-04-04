using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IOpenApiSpec
	{
		/// <summary>
		/// getOrganizationOpenapiSpec
		/// </summary>
		/// <remarks>
		/// Return the OpenAPI 2.0 Specification of the organization&#39;s API documentation in JSON
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/openapiSpec")]
		Task<object> GetOrganizationOpenapiSpec(
			[AliasAs("organizationId")]string organizationId
			);
	}
}
