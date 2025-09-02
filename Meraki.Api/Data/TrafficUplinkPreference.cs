namespace Meraki.Api.Data;

/// <summary>
/// Traffic uplink preferences
/// </summary>
[DataContract]
public class TrafficUplinkPreference
{
	/// <summary>
	/// Array of traffic filters for this uplink preference rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "trafficFilters")]
	public List<TrafficFilters>? TrafficFilters { get; set; }

	/// <summary>
	/// Preferred uplink for uplink preference rule. Must be one of: 'wan1' or 'wan2', or any other valid uplink(wanX) if it applies to the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "preferredUplink")]
	public string? PreferredUplink { get; set; }

	/// <summary>
	/// Fail over criterion for this uplink preference rule. Must be one of: 'poorPerformance' or 'uplinkDown'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "failOverCriterion")]
	public FailOverCriterion? FailOverCriterion { get; set; }

	/// <summary>
	///	Performance class setting for this uplink preference rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "performanceClass")]
	public PerformanceClass? PerformanceClass { get; set; }
}
