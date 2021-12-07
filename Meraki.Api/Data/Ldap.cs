namespace Meraki.Api.Data;

/// <summary>
/// Ldap
/// </summary>
[DataContract]
public class Ldap
{
	/// <summary>
	/// The base distinguished name of users on the LDAP server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "baseDistinguishedName")]
	public string BaseDistinguishedName { get; set; } = string.Empty;

	/// <summary>
	/// (Optional) The credentials of the user account to be used by the AP to bind to your LDAP server. The LDAP account should have permissions on all your LDAP servers.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "credentials")]
	public LdapCredentials? Credentials { get; set; }

	/// <summary>
	/// The CA certificate used to sign the LDAP server's key.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serverCaCertificate")]
	public ServerCaCertificate ServerCaCertificate { get; set; } = new();

	/// <summary>
	/// The LDAP servers to be used for authentication.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "servers")]
	public List<LdapServer> Servers { get; set; } = new();
}
