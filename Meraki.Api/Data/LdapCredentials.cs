namespace Meraki.Api.Data;

/// <summary>
/// (Optional) The credentials of the user account to be used by the AP to bind to your LDAP server. The LDAP account should have permissions on all your LDAP servers.
/// </summary>
public class LdapCredentials
{
	/// <summary>
	/// The distinguished name of the LDAP user account (example: cn=user,dc=meraki,dc=com).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "distinguishedName")]
	public string DistinguishedName { get; set; } = string.Empty;

	/// <summary>
	/// The password of the LDAP user account.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "password")]
	public string Password { get; set; } = string.Empty;
}
