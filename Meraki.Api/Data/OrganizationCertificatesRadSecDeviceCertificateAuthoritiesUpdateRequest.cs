namespace Meraki.Api.Data;

/// <summary>
/// Organization Certificates RadSec Device Certificate Authorities Update Request
/// </summary>
[DataContract]
public class OrganizationCertificatesRadSecDeviceCertificateAuthoritiesUpdateRequest
{
	/// <summary>
	/// The "status" to update the Certificate Authority to. Only valid option is "trusted".
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; }
}
