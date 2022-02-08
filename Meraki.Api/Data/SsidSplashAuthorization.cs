namespace Meraki.Api.Data;

/// <summary>
/// Splash authorization for SSID 0
/// </summary>
[DataContract]
public class SsidSplashAuthorization
{
	/// <summary>
	/// New authorization status for the SSID (true, false).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isAuthorized")]
	public bool IsAuthorized { get; set; }

	/// <summary>
	/// Authorized at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authorizedAt")]
	public DateTime? AuthorizedAt { get; set; }

	/// <summary>
	/// Expires at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expiresAt")]
	public DateTime? ExpiresAt { get; set; }
}
