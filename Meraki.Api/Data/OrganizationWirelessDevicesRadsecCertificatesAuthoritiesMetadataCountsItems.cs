namespace Meraki.Api.Data;

/// <summary>
/// Counts of the Certificate Authorities
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesMetadataCountsItems
{
	/// <summary>
	/// Number of remaining Certificate Authorities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// Total number of Certificate Authorities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}