namespace Meraki.Api.Data;

/// <summary>
/// Organization Certificates
/// </summary>
[DataContract]
public class OrganizationCertificates
{
	/// <summary>
	/// ID of certificate in trusted_certificates ID table
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "certificateId")]
	public string CertificateId { get; set; } = string.Empty;

	/// <summary>
	/// Description of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// ID of certificate's parent in trusted_certificates ID table
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "parentCertificateId")]
	public string ParentCertificateId { get; set; } = string.Empty;

	/// <summary>
	/// Certificate Manager enum = ["NAC", "Systems Manager"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public string Source { get; set; } = string.Empty;

	/// <summary>
	/// Components of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fields")]
	public OrganizationCertificatesFields Fields { get; set; } = new();
}
