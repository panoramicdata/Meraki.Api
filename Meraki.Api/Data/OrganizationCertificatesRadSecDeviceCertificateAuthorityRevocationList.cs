namespace Meraki.Api.Data;

/// <summary>
/// Organization Certificates RADSEC Device Certificate Authority Revocation List
/// </summary>
[DataContract]
public class OrganizationCertificatesRadSecDeviceCertificateAuthorityRevocationList
{
	/// <summary>
	/// The PEM encoded contents of the CA's certificate revocation list (full CRL) - with newlines as "".
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "crl")]
	public string Crl { get; set; } = string.Empty;
}
