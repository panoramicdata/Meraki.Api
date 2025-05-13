namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect site delete request.
/// </summary>
[DataContract]
public class SecureConnectSiteDeleteRequest
{
	/// <summary>
	/// List of site IDs to detach
	/// </summary>
	[DataMember(Name = "sites")]
	public List<string>? Sites { get; set; }

	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public SecureConnectSiteCallback? Callback { get; set; }
}
