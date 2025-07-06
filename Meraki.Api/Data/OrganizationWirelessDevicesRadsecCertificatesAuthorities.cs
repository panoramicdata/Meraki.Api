namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Radsec Certificates Authorities
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthorities
{
	/// <summary>
	/// Metadata about the Certificate Authorities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessDevicesRadsecCertificatesAuthoritiesMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of Certificate Authorities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessDevicesRadsecCertificatesAuthority> Items { get; set; } = [];
}
