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
	public interface IMerakiAuthUsers
	{
		/// <summary>
		/// Return the Meraki Auth splash guest, RADIUS, or client VPN user
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="merakiAuthUserId">The meraki user id</param>
		[Get("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
		Task<MerakiAuthUsers> GetNetworkMerakiAuthUserAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a user configured with Meraki Authentication
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="merakiAuthUserId">The meraki user id</param>
		/// <param name="UpdateNetworkMerakiAuthUser">Body for updating a user</param>
		[Put("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
		Task<MerakiAuthUsers> UpdateNetworkMerakiAuthUserAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
			[Body] MerakiAuthUsers UpdateNetworkMerakiAuthUser,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the users configured under Meraki Authentication for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/merakiAuthUsers")]
		Task<List<MerakiAuthUsers>> GetNetworkMerakiAuthUsersAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a user configured with Meraki Authentication
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkMerakiAuthUser">Body for updating a meraki user</param>
		[Put("/networks/{networkId}/merakiAuthUsers")]
		Task<MerakiAuthUsers> UpdateNetworkMerakiAuthUserAsync(
			[AliasAs("networkId")] string networkId,
			[Body] MerakiAuthUsers UpdateNetworkMerakiAuthUser,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Authorize a user configured with Meraki Authentication for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkMerakiAuthUser">Body for authorizing a meraki user</param>
		[Post("/networks/{networkId}/merakiAuthUsers")]
		Task<MerakiAuthUsers> CreateNetworkMerakiAuthUserAsync(
			[AliasAs("networkId")] string networkId,
			[Body] MerakiAuthUsers CreateNetworkMerakiAuthUser,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Deauthorize a user
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="merakiAuthUserId">The meraki user id</param>
		[Delete("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
		Task DeleteNetworkMerakiAuthUserAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
			CancellationToken cancellationToken = default);
	}
}
