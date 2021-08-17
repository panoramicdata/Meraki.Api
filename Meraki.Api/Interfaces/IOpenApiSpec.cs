using Meraki.Api.Data;
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
		/// Return the OpenAPI 2.0 Specification of the organization&#39;s API documentation in JSON
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/openapiSpec")]
		Task<OpenApiSpecs> GetOrganizationOpenapiSpecAsync(
			[AliasAs("organizationId")]string organizationId
			);
	}
}
