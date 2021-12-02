namespace Meraki.Api.Data;

/// <summary>
/// The current setting for password-based authentication.
/// </summary>
[DataContract]
public class PasswordAuthentication
{
	/// <summary>
	/// Whether or not to use EAP-TTLS/PAP or PEAP-GTC password-based authentication via LDAP lookup.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
