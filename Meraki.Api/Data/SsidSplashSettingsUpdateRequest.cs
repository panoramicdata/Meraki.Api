namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSsidSplashSettings
/// </summary>
[DataContract]
public class SsidSplashSettingsUpdateRequest
{
	/// <summary>
	/// [optional] The custom splash URL of the click-through splash page. Note that the URL can be configured without necessarily being used. In order to enable the custom URL, see &#39;useSplashUrl&#39;
	/// </summary>
	/// <value>[optional] The custom splash URL of the click-through splash page. Note that the URL can be configured without necessarily being used. In order to enable the custom URL, see &#39;useSplashUrl&#39;</value>
	[DataMember(Name = "splashUrl")]
	public string SplashUrl { get; set; } = string.Empty;
	/// <summary>
	/// [optional] Boolean indicating whether the user will be redirected to the custom splash url. A custom splash URL must be set if this is true. Note that depending on your SSID&#39;s access control settings, it may not be possible to use the custom splash URL.
	/// </summary>
	/// <value>[optional] Boolean indicating whether the user will be redirected to the custom splash url. A custom splash URL must be set if this is true. Note that depending on your SSID&#39;s access control settings, it may not be possible to use the custom splash URL.</value>
	[DataMember(Name = "useSplashUrl")]
	public bool? UseSplashUrl { get; set; }
}
