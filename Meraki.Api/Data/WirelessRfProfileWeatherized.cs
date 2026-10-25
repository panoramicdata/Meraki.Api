namespace Meraki.Api.Data;

/// <summary>
/// Weatherized settings for an RF profile - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class WirelessRfProfileWeatherized
{
	/// <summary>
	/// Deployment settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deployment")]
	public WirelessRfProfileWeatherizedDeployment? Deployment { get; set; }
}
