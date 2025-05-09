namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Application Group Delete Request
/// </summary>
[DataContract]
public class SecureConnectPrivateApplicationGroupDeleteRequest
{
	/// <summary>
	/// Boolean flag to force delete application group, even if application group is in use by one or more rules.
	/// </summary>
	[DataMember(Name = "force")]
	public bool? Force { get; set; }
}
