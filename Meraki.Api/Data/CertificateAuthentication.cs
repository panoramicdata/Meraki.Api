namespace Meraki.Api.Data;

/// <summary>
/// The current setting for certificate verification.
/// </summary>
[DataContract]
public class CertificateAuthentication
{
	/// <summary>
	/// (Optional) The URL of the OCSP responder to verify client certificate status.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ocspResponderUrl")]
	public string? OcspResponderUrl { get; set; }

	/// <summary>
	/// Whether or not to use EAP-TLS certificate-based authentication to validate wireless clients.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Whether or not to verify the certificate with LDAP.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useLdap")]
	public bool UseLdap { get; set; }

	/// <summary>
	/// Whether or not to verify the certificate with OCSP.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useOcsp")]
	public bool UseOcsp { get; set; }

	/// <summary>
	/// The Client CA Certificate used to sign the client certificate.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "clientRootCaCertificate")]
	public ServerCaCertificate ClientRootCaCertificate { get; set; } = new();
}
