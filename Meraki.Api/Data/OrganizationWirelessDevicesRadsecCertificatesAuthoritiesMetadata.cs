namespace Meraki.Api.Data;

/// <summary>
/// Metadata about the Certificate Authorities
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesMetadata
{
	/// <summary>
	/// Counts of the Certificate Authorities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessDevicesRadsecCertificatesAuthoritiesMetadataCounts Counts { get; set; } = new();
}
