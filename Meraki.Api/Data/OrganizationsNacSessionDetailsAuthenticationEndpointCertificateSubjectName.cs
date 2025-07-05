namespace Meraki.Api.Data;

/// <summary>
/// Endpoint Certificate Subject Name
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificateSubjectName
{
	/// <summary>
	/// Common Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "commonName")]
	public string CommonName { get; set; } = string.Empty;

	/// <summary>
	/// Country
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "country")]
	public string Country { get; set; } = string.Empty;

	/// <summary>
	/// Locality
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "locality")]
	public string Locality { get; set; } = string.Empty;

	/// <summary>
	/// Organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organization")]
	public string Organization { get; set; } = string.Empty;

	/// <summary>
	/// Organizational Unit
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationalUnit")]
	public string OrganizationalUnit { get; set; } = string.Empty;

	/// <summary>
	/// State
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "state")]
	public string State { get; set; } = string.Empty;
}