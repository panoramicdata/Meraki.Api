namespace Meraki.Api.Data;

/// <summary>
/// Components of Certificate's Issuer
/// </summary>
[DataContract]
public class OrganizationCertificatesFieldsIssuer
{
	/// <summary>
	/// Common Name of Certificate's Issuer
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "commonName")]
	public string CommonName { get; set; } = string.Empty;

	/// <summary>
	/// Country Name of Certificate's Issuer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "country")]
	public string Country { get; set; } = string.Empty;

	/// <summary>
	/// Locality of Certificate's Issuer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "locality")]
	public string Locality { get; set; } = string.Empty;

	/// <summary>
	/// Organization of Certificate's Issuer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organization")]
	public string Organization { get; set; } = string.Empty;

	/// <summary>
	/// Organization of Certificate's Issuer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationalUnit")]
	public string OrganizationalUnit { get; set; } = string.Empty;

	/// <summary>
	/// State or Province Name of Certificate's Issuer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "state")]
	public string State { get; set; } = string.Empty;
}