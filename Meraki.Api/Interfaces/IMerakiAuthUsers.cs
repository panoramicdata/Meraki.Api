using Refit;
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
		/// Return the Meraki Auth splash or RADIUS user
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="merakiAuthUserId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
		Task<object> GetNetworkMerakiAuthUser(
			[AliasAs("networkId")]string networkId,
			[AliasAs("merakiAuthUserId")]string merakiAuthUserId
			);

		/// <summary>
		/// getNetworkMerakiAuthUsers
		/// </summary>
		/// <remarks>
		/// List the splash or RADIUS users configured under Meraki Authentication for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/merakiAuthUsers")]
		Task<object> GetNetworkMerakiAuthUsers(
			[AliasAs("networkId")]string networkId
			);
	}
}
