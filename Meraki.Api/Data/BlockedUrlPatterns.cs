namespace Meraki.Api.Data;

/// <summary>
/// Settings for blacklisted URL patterns
/// </summary>
[DataContract]
public class BlockedUrlPatterns
{
	/// <summary>
	/// Gets or Sets Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "settings")]
	public UrlSetting Settings { get; set; }

	/// <summary>
	/// A blacklist of URL patterns to block
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "patterns")]
	public List<string> Patterns { get; set; } = null!;
}
