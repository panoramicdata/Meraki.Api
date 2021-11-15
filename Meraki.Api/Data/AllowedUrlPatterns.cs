namespace Meraki.Api.Data;

/// <summary>
/// Settings for whitelisted URL patterns
/// </summary>
[DataContract]
public class AllowedUrlPatterns
{
	/// <summary>
	/// Gets or Sets Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "settings")]
	public UrlSetting Settings { get; set; }

	/// <summary>
	/// A whitelist of URL patterns to allow
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "patterns")]
	public List<string> Patterns { get; set; } = new();
}
