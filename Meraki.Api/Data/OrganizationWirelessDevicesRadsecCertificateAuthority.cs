namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Radsec Certificate Authority
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificateAuthority
{
	/// <summary>
	/// A unique identifier for a CA which can be used to fetch the status, update the status, and read the CRL for that CA. The id of a CA will be provided as part of the response once a CA is generated.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authorityId")]
	public string AuthorityId { get; set; } = string.Empty;

	/// <summary>
	/// The PEM encoded contents of the Certificate Authority - with newlines as "". Contents can be null, if the cert has not yet been generated.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "contents")]
	public string Contents { get; set; } = string.Empty;

	/// <summary>
	/// The status of the Certificate Authority - one of "generating", "untrusted" or "trusted"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public AuthorityStatus Status { get; set; } = AuthorityStatus.Generating;
}
