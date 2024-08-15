namespace Meraki.Api.Data;

/// <summary>
/// The CA certificate used to sign the LDAP server's key.
/// </summary>
[DataContract]
public class ServerCaCertificate
{
	/// <summary>
	/// The contents of the CA certificate. Must be in PEM or DER format.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "contents")]
	public string? Contents { get; set; }

	/// <summary>
	/// Name - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Expiration Date - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "expirationDate")]
	public string? ExpirationDate { get; set; }

	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }
}
