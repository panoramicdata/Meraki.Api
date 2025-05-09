namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Application Delete Request
/// </summary>
[DataContract]
public class SecureConnectPrivateApplicationDeleteRequest
{
	/// <summary>
	/// Boolean flag to force delete application, even if application is in use by one or more rules.
	/// </summary>
	[DataMember(Name = "force")]
	public bool? Force { get; set; }
}
