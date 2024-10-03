namespace Meraki.Api.Data;

/// <summary>
/// The LDAP servers to be used for authentication.
/// </summary>
[DataContract]
public class LdapServer
{
	/// <summary>
	/// UDP port the LDAP server listens on.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "port")]
	public int Port { get; set; }

	/// <summary>
	/// IP address of your LDAP server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = string.Empty;

	/// <summary>
	/// LDAP Server Id - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}
