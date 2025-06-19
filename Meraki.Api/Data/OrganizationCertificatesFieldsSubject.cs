namespace Meraki.Api.Data;

/// <summary>
/// Components of Certificate
/// </summary>
[DataContract]
public class OrganizationCertificatesFieldsSubject
{
	/// <summary>
	/// Common Name of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "commonName")]
	public string CommonName { get; set; } = string.Empty;

	/// <summary>
	/// Country Name of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "country")]
	public string Country { get; set; } = string.Empty;

	/// <summary>
	/// Locality of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "locality")]
	public string Locality { get; set; } = string.Empty;

	/// <summary>
	/// Organization of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organization")]
	public string Organization { get; set; } = string.Empty;

	/// <summary>
	/// Organizational Unit of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationalUnit")]
	public string OrganizationUnit { get; set; } = string.Empty;

	/// <summary>
	/// State Or Province Name of Certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "state")]
	public string State { get; set; } = string.Empty;
}