using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IContentFilteringRules
	{
		/// <summary>
		/// getNetworkContentFiltering
		/// </summary>
		/// <remarks>
		/// Return the content filtering settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/contentFiltering")]
		Task<object> GetNetworkContentFiltering(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkContentFiltering
		/// </summary>
		/// <remarks>
		/// Update the content filtering settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkContentFiltering"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/contentFiltering")]
		Task<object> UpdateNetworkContentFiltering(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkContentFilteringUpdateRequest updateNetworkContentFiltering
			);
	}
}
