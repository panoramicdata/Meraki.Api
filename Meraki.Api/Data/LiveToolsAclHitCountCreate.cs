namespace Meraki.Api.Data;

/// <summary>
/// Live Tools ACL Hit Count Create
/// </summary>
[DataContract]
public class LiveToolsAclHitCountCreate
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public LiveToolsAclHitCountCreateCallback? Callback { get; set; }
}
