namespace Meraki.Api.Data;

/// <summary>
/// Counts of the Certificate Authorities
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesMetadataCounts
{
	/// <summary>
	/// Counts of the Certificate Authorities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationWirelessDevicesRadsecCertificatesAuthoritiesMetadataCountsItems Items { get; set; } = new();
}
