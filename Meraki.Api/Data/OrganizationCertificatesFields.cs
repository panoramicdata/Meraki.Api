namespace Meraki.Api.Data;

/// <summary>
/// Components of Certificate
/// </summary>
[DataContract]
public class OrganizationCertificatesFields
{
	/// <summary>
	/// Certificate Policy String
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// Certificate's public key algorithm
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "publicKeyAlgorithm")]
	public string PublicKeyAlgorithm { get; set; } = string.Empty;

	/// <summary>
	/// Certificate Serial Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Signature algorithm ID of the certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "signatureAlgorithmId")]
	public string SignatureAlgorithmId { get; set; } = string.Empty;

	/// <summary>
	/// Alternative name of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subjectAlternativeName")]
	public string SubjectAlternativeName { get; set; } = string.Empty;

	/// <summary>
	/// Certificate Version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	/// <summary>
	/// Components of Certificate's Issuer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "issuer")]
	public OrganizationCertificatesFieldsIssuer Issuer { get; set; } = new();

	/// <summary>
	/// Certificate's key usage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "keyUsage")]
	public OrganizationCertificatesFieldsKeyUsage KeyUsage { get; set; } = new();

	/// <summary>
	/// Components of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "subject")]
	public OrganizationCertificatesFieldsSubject Subject { get; set; } = new();

	/// <summary>
	/// Validity dates of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "validity")]
	public OrganizationCertificatesFieldsValidity Validity { get; set; } = new();

	/// <summary>
	/// Certificate Hash Information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hashes")]
	public List<OrganizationCertificatesFieldsHash> Hashes { get; set; } = [];
}
