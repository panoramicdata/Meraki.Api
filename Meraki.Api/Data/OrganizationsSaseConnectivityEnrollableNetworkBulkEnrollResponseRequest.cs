namespace Meraki.Api.Data;

/// <summary>
/// Request that was sent to the job
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollResponseRequest
{
	/// <summary>
	/// ID of the region to enroll the site in
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "regionId")]
	public string RegionId { get; set; } = string.Empty;

	/// <summary>
	/// ID of the site to enroll
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "siteId")]
	public string SiteId { get; set; } = string.Empty;
}
