namespace Meraki.Api.Data;

/// <summary>
/// Appliance Uplinks Statuses Overview
/// </summary>
[DataContract]
public class ApplianceUplinksStatusesOverview
{
	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public ApplianceUplinksStatusesOverviewCounts Counts { get; set; } = new();
}
