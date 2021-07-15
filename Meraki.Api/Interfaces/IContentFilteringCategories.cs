using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IContentFilteringCategories
	{
		/// <summary>
		/// getNetworkContentFilteringCategories
		/// </summary>
		/// <remarks>
		/// List all available content filtering categories for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/contentFiltering/categories")]
		Task<object> GetNetworkContentFilteringCategories(
			[AliasAs("networkId")]string networkId
			);
	}
}
