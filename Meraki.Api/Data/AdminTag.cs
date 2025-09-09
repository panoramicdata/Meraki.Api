namespace Meraki.Api.Data;

/// <summary>
/// Tag
/// </summary>
[DataContract]
public class AdminTag
{
	/// <summary>
	/// The name of the tag
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tag")]
	public string TagText { get; set; } = string.Empty;

	/// <summary>
	/// The privilege of the SAML administrator on the tag. Can be one of 'full', 'read-only', 'guest-ambassador', 'monitor-only' or 'custom-role'
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "access")]
	public string Access { get; set; } = string.Empty;
}
