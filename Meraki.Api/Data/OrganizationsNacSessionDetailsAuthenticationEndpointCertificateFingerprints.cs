namespace Meraki.Api.Data;

/// <summary>
/// Endpoint Certificate Finger Prints
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificateFingerprints
{
	/// <summary>
	/// SHA 1
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sha1")]
	public string Sha1 { get; set; } = string.Empty;

	/// <summary>
	/// SHA 256
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sha256")]
	public string Sha256 { get; set; } = string.Empty;
}