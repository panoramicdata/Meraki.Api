namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect site create request.
/// </summary>
[DataContract]
public class SecureConnectSiteCreateRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public SecureConnectSiteCreateRequestCallback? Callback { get; set; }

	/// <summary>
	/// List of Meraki SD-WAN sites with the associated regions to be enrolled.
	/// </summary>
	[DataMember(Name = "enrollments")]
	public List<SecureConnectSiteCreateRequestEnrollment>? Enrollments { get; set; }
}
