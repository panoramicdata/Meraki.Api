namespace Meraki.Api.Data;

/// <summary>
/// Metadata about the CRLs
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrlsMetadata
{
	/// <summary>
	/// Counts of the CRLs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrlsMetadataCounts Counts { get; set; } = new();
}
