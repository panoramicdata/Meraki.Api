namespace Meraki.Api.Data;

/// <summary>
/// Appliance Uplinks Statuses Overview Counts
/// </summary>
[DataContract]
public class ApplianceUplinksStatusesOverviewCounts
{
	/// <summary>
	/// By Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byStatus")]
	public ApplianceUplinksStatusesOverviewCountsByStatus ByStatus { get; set; } = new();
}
