namespace Meraki.Api.Data;

/// <summary>
/// policy with respective traffic filters for an MX network
/// </summary>
[DataContract]
public class OrganizationApplianceSdwanInternetPoliciesPreference
{
	/// <summary>
	/// WAN failover and failback behavior
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failOverCriterion")]
	public FailOverCriterion FailOverCriterion { get; set; }

	/// <summary>
	/// Preferred uplink for uplink preference rule. Must be one of: 'wan1', 'wan2', 'bestForVoIP', 'loadBalancing' or 'defaultUplink'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "preferredUplink")]
	public PreferredUplink PreferredUplink { get; set; }

	/// <summary>
	/// Performance class setting for uplink preference rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "performanceClass")]
	public OrganizationApplianceSdwanInternetPoliciesPreferencePerformanceClass PerformanceClass { get; set; } = new();

	/// <summary>
	/// Traffic filters
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "trafficFilters")]
	public List<OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilter> TrafficFilters { get; set; } = [];
}
