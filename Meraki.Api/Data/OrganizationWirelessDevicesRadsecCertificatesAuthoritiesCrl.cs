namespace Meraki.Api.Data;

/// <summary>
/// CRL for the specified CA
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrl
{
	/// <summary>
	/// The ID of the Certificate Authority
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "certificateAuthorityId")]
	public string CertificateAuthorityId { get; set; } = string.Empty;

	/// <summary>
	/// The PEM encoded CRL for the Certificate Authority
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "crl")]
	public string Crl { get; set; } = string.Empty;
}