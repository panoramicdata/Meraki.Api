namespace Meraki.Api.Data;

/// <summary>
/// The current setting for Local Authentication, a built-in RADIUS server on the access point. Only valid if authMode is '8021x-localradius'.
/// </summary>
[DataContract]
public class LocalRadius
{
	/// <summary>
	/// The duration (in seconds) for which LDAP and OCSP lookups are cached.
	/// </summary>
	[DataMember(Name = "cacheTimeout")]
	public int CacheTimeout { get; set; }

	/// <summary>
	/// The current setting for certificate verification.
	/// </summary>
	[DataMember(Name = "certificateAuthentication")]
	public CertificateAuthentication CertificateAuthentication { get; set; } = new();

	/// <summary>
	/// The current setting for password-based authentication.
	/// </summary>
	[DataMember(Name = "passwordAuthentication")]
	public PasswordAuthentication PasswordAuthentication { get; set; } = new();
}
