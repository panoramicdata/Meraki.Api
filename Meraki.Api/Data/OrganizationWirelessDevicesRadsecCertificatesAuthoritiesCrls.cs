namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Radsec Certificates Authorities Crls
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrls
{
	/// <summary>
	/// Metadata about the CRLs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrlsMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of CRLs for the specified CAs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrl> Items { get; set; } = [];
}
