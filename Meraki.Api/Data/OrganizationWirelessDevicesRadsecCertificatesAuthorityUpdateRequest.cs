namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Radsec Certificates Authority Update Request
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthorityUpdateRequest
{
	/// <summary>
	/// The ID of the Certificate Authority to update.
	/// </summary>
	[DataMember(Name = "certificateAuthorityId")]
	public string? CertificateAuthorityId { get; set; }

	/// <summary>
	/// The "status" to update the Certificate Authority to. Only valid option is "trusted".
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; }
}
