namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Radsec Certificate Authority Update Request
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificateAuthorityUpdateRequest
{
	/// <summary>
	/// The "status" to update the Certificate Authority to. Only valid option is "trusted".
	/// </summary>
	[DataMember(Name = "status")]
	public AuthorityStatus? Status { get; set; }
}
