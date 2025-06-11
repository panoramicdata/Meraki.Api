namespace Meraki.Api.Data;

/// <summary>
/// Certificate Authority
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesItem
{
	/// <summary>
	/// The ID of the Certificate Authority
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "certificateAuthorityId")]
	public string CertificateAuthorityId { get; set; } = string.Empty;

	/// <summary>
	/// The PEM encoded contents of the Certificate Authority - with newlines as "" Contents can be null, if the cert has not yet been generated.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "contents")]
	public string? Contents { get; set; }

	/// <summary>
	/// The status of the Certificate Authority
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}