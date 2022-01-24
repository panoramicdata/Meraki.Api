namespace Meraki.Api.Data;

/// <summary>
/// The content filtering settings for your group policy
/// </summary>
[DataContract]
public class GroupPolicyContentFiltering
{
	/// <summary>
	/// Gets or Sets AllowedUrlPatterns
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedUrlPatterns")]
	public AllowedUrlPatterns AllowedUrlPatterns { get; set; } = new();

	/// <summary>
	/// Gets or Sets BlockedUrlPatterns
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "blockedUrlPatterns")]
	public BlockedUrlPatterns BlockedUrlPatterns { get; set; } = new();

	/// <summary>
	/// Gets or Sets BlockedUrlCategories
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "blockedUrlCategories")]
	public BlockedUrlCategories BlockedUrlCategories { get; set; } = new();
}
