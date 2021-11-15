namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Splash login attempts
/// </summary>
public interface INetworksSplashLoginAttempts
{
	/// <summary>
	/// List the splash login attempts for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="ssidNumber">Only return the login attempts for the specified SSID (optional)</param>
	/// <param name="loginIdentifier">The username, email, or phone number used during login (optional)</param>
	/// <param name="timespan">The timespan, in seconds, for the login attempts. The period will be from [timespan] seconds ago until now. The maximum timespan is 3 months (optional)</param>
	[Get("/networks/{networkId}/splashLoginAttempts")]
	Task<List<SplashLoginAttempts>> GetAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("ssidNumber")] string ssidNumber = null!,
		[AliasAs("loginIdentifier")] string loginIdentifier = null!,
		[AliasAs("timespan")] int? timespan = null,
		CancellationToken cancellationToken = default);
}
