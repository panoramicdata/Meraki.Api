namespace Meraki.Api.Data;

/// <summary>
/// policies with respective traffic filters for an MX network
/// </summary>
[DataContract]
public class WanTrafficUplinkPreference
{
	/// <summary>
	/// WAN failover and failback behavior. Valid values are 'poorPerformance', 'uplinkDown'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "failOverCriterion")]
	public FailOverCriterion? FailOverCriterion { get; set; }

	/// <summary>
	/// Preferred uplink for uplink preference rule. Must be one of: 'wan1', 'wan2', 'bestForVoIP', 'loadBalancing' or 'defaultUplink'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "preferredUplink")]
	public PreferredUplink? PreferredUplink { get; set; }

	/// <summary>
	/// Performance class setting for uplink preference rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "performanceClass")]
	public PerformanceClass? PerformanceClass { get; set; }

	/// <summary>
	/// Traffic filters
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "trafficFilters")]
	public List<TrafficFilters>? TrafficFilters { get; set; }
}
