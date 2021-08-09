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
		/// getNetworkMerakiAuthUser
		/// </summary>
		/// <remarks>
		/// Return the Meraki Auth splash guest, RADIUS, or client VPN user
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="merakiAuthUserId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
		Task<MerakiAuthUsers> GetNetworkMerakiAuthUser(
			[AliasAs("networkId")]string networkId,
			[AliasAs("merakiAuthUserId")]string merakiAuthUserId
			);

		/// <summary>
		/// updateNetworkMerakiAuthUser
		/// </summary>
		/// <remarks>
		/// Update a user configured with Meraki Authentication (currently, 802.1X RADIUS, splash guest, and client VPN users can be updated)
		///		</remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="merakiAuthUserId"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
		Task<MerakiAuthUsers> UpdateNetworkMerakiAuthUser(
			[AliasAs("networkId")] string networkId,
			[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
			[Body]MerakiAuthUsers updateNetworkMerakiAuthUser
			);

		/// <summary>
		/// getNetworkMerakiAuthUsers
		/// </summary>
		/// <remarks>
		/// List the users configured under Meraki Authentication for a network (splash guest or RADIUS users for a wireless network, or client VPN users for a wired network)
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/merakiAuthUsers")]
		Task<List<MerakiAuthUsers>> GetNetworkMerakiAuthUsers(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkMerakiAuthUser
		/// </summary>
		/// <remarks>
		/// Update a user configured with Meraki Authentication (currently, 802.1X RADIUS, splash guest, and client VPN users can be updated)
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkMerakiAuthUser"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/merakiAuthUsers")]
		Task<MerakiAuthUsers> UpdateNetworkMerakiAuthUser(
			[AliasAs("networkId")] string networkId,
			[Body] MerakiAuthUsers updateNetworkMerakiAuthUser
			);

		/// <summary>
		/// createNetworkMerakiAuthUser
		/// </summary>
		/// <remarks>
		/// Authorize a user configured with Meraki Authentication for a network (currently supports 802.1X, splash guest, and client VPN users, and currently, organizations have a 50,000 user cap)
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkMerakiAuthUser"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/merakiAuthUsers")]
		Task<MerakiAuthUsers> CreateNetworkMerakiAuthUser(
			[AliasAs("networkId")] string networkId,
			[Body] MerakiAuthUsers createNetworkMerakiAuthUser
			);

		/// <summary>
		/// deleteNetworkMerakiAuthUser
		/// </summary>
		/// <remarks>
		/// Deauthorize a user
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="merakiAuthUserId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
		Task DeleteNetworkMerakiAuthUserAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
			CancellationToken cancellationToken = default);
	}
}
