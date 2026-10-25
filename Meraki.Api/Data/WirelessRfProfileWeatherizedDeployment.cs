namespace Meraki.Api.Data;

/// <summary>
/// Weatherized deployment settings for an RF profile - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class WirelessRfProfileWeatherizedDeployment
{
	/// <summary>
	/// The deployment mode. Only 'outdoor' has been observed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }
}
