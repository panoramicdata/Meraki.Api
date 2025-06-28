namespace Meraki.Api.Data;

/// <summary>
/// Endpoint Certificate Issuer Name
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificateIssuerName
{
	/// <summary>
	/// Common Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "commonName")]
	public string CommonName { get; set; } = string.Empty;

	/// <summary>
	/// Parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "parameters")]
	public string Parameters { get; set; } = string.Empty;

	/// <summary>
	/// Serial Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Signature Algorithm
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "signatureAlgorithm")]
	public string SignatureAlgorithm { get; set; } = string.Empty;

	/// <summary>
	/// Version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	/// <summary>
	/// Endpoint Certificate Validity Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "validity")]
	public OrganizationsNacSessionDetailsAuthenticationEndpointCertificateIssuerNameValidity Validity { get; set; } = new();
}
