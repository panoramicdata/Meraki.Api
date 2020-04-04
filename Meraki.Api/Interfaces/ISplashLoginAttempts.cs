using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISplashLoginAttempts
	{
		/// <summary>
		/// getNetworkSplashLoginAttempts
		/// </summary>
		/// <remarks>
		/// List the splash login attempts for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="ssidNumber">Only return the login attempts for the specified SSID (optional)</param>
		/// <param name="loginIdentifier">The username, email, or phone number used during login (optional)</param>
		/// <param name="timespan">The timespan, in seconds, for the login attempts. The period will be from [timespan] seconds ago until now. The maximum timespan is 3 months (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/splashLoginAttempts")]
		Task<object> GetNetworkSplashLoginAttempts(
			[AliasAs("networkId")]string networkId,
			[AliasAs("ssidNumber")]string ssidNumber = null!,
			[AliasAs("loginIdentifier")]string loginIdentifier = null!,
			[AliasAs("timespan")]int? timespan = null);
	}
}
