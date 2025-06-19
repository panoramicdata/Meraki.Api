namespace Meraki.Api.Data;

/// <summary>
/// Counts of the CRLs
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrlsMetadataCounts
{
	/// <summary>
	/// Counts of the CRLs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrlsMetadataCountsItems Items { get; set; } = new();
}
