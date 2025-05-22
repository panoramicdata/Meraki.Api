namespace Meraki.Api.Data;

/// <summary>
/// A Meraki SD-WAN site with the associated region to be enrolled.
/// </summary>
[DataContract]
public class SecureConnectSiteCreateRequestEnrollment
{
	/// <summary>
	/// ID of the region to enroll the site in
	/// </summary>
	[DataMember(Name = "regionId")]
	public string? RegionId { get; set; }

	/// <summary>
	/// Name of the region to enroll the site in. This is an optional param for the case where the site is being enrolled in a new region that hasn't been deployed yet.
	/// </summary>
	[DataMember(Name = "regionName")]
	public string? RegionName { get; set; }

	/// <summary>
	/// Type of region to enroll the site in (one of: 'CNHE' or 'CloudHub')
	/// </summary>
	[DataMember(Name = "regionType")]
	public RegionType RegionType { get; set; }

	/// <summary>
	/// Network ID of the site to enroll
	/// </summary>
	[DataMember(Name = "siteId")]
	public string SiteId { get; set; } = string.Empty;
}
