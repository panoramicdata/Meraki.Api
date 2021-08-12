using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IContentFilteringRules
	{
		/// <summary>
		/// Return the content filtering settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/contentFiltering")]
		Task<ContentFiltering> GetNetworkApplianceContentFilteringAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the content filtering settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="NetworkContentFilteringUpdateRequest">Body for updating content filtering settings</param>
		[Put("/networks/{networkId}/contentFiltering")]
		Task<ContentFiltering> UpdateNetworkContentFilteringAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkContentFilteringUpdateRequest NetworkContentFilteringUpdateRequest,
			CancellationToken cancellationToken = default
			);
	}
}
