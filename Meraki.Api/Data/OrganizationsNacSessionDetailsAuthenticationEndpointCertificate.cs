namespace Meraki.Api.Data;

/// <summary>
/// Endpoint Certificate used for Authentication
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificate
{
	/// <summary>
	/// Endpoint Certificate Issuer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "issuer")]
	public string Issuer { get; set; } = string.Empty;

	/// <summary>
	/// Endpoint Certificate Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Endpoint Certificate Title
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Endpoint Certificate is Expired
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isExpired")]
	public bool IsExpired { get; set; }

	/// <summary>
	/// Endpoint Certificate Directory Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "directoryName")]
	public OrganizationsNacSessionDetailsAuthenticationEndpointCertificateDirectoryName DirectoryName { get; set; } = new();

	/// <summary>
	/// Endpoint Certificate Finger Prints
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fingerprints")]
	public OrganizationsNacSessionDetailsAuthenticationEndpointCertificateFingerprints Fingerprints { get; set; } = new();

	/// <summary>
	/// Endpoint Certificate Issuer Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "issuerName")]
	public OrganizationsNacSessionDetailsAuthenticationEndpointCertificateIssuerName IssuerName { get; set; } = new();

	/// <summary>
	/// Endpoint Certificate Public Key
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "publicKey")]
	public OrganizationsNacSessionDetailsAuthenticationEndpointCertificatePublicKey PublicKey { get; set; } = new();

	/// <summary>
	/// Endpoint Certificate Subject Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subjectName")]
	public OrganizationsNacSessionDetailsAuthenticationEndpointCertificateSubjectName SubjectName { get; set; } = new();

	/// <summary>
	/// Endpoint Certificate Extensions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "extensions")]
	public List<OrganizationsNacSessionDetailsAuthenticationEndpointCertificateExtension> Extensions { get; set; } = [];
}
