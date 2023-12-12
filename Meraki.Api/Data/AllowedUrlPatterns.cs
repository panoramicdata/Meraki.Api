namespace Meraki.Api.Data;

/// <summary>
/// Settings for allowed URL patterns
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
	/// URL patterns to allow
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "patterns")]
	public List<string> Patterns { get; set; } = [];
}
