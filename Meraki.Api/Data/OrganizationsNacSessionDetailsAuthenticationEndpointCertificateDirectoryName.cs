namespace Meraki.Api.Data;

/// <summary>
/// Endpoint Certificate Directory Name
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificateDirectoryName
{
	/// <summary>
	/// Common Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "commonName")]
	public string CommonName { get; set; } = string.Empty;

	/// <summary>
	/// Serial Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}