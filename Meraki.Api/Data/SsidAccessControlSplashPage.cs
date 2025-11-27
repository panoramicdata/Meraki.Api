namespace Meraki.Api.Data;

/// <summary>
/// SSID access control splash page settings
/// </summary>
[DataContract]
public class SsidAccessControlSplashPage
{
	/// <summary>
	/// Whether splash page is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The splash page theme
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "theme")]
	public string? Theme { get; set; }
}
