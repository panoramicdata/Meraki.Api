namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Certificates Open Roaming Certificate Authority
/// </summary>
[DataContract]
public class OrganizationWirelessCertificatesOpenRoamingCertificateAuthority
{
	/// <summary>
	/// The PEM encoded contents of the Certificate Authority - with newlines as ""
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "contents")]
	public string Contents { get; set; } = string.Empty;

	/// <summary>
	/// he status of the Certificate Authority - one of "untrusted" or "trusted".
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
