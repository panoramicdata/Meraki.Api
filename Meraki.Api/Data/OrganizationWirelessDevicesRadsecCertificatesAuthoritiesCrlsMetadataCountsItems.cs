namespace Meraki.Api.Data;

/// <summary>
/// Counts of the CRLs
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesRadsecCertificatesAuthoritiesCrlsMetadataCountsItems
{
	/// <summary>
	/// Number of remaining CRLs 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// Total number of CRLs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}