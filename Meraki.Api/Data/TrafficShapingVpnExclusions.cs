namespace Meraki.Api.Data;

/// <summary>
/// TrafficShapingVpnExclusions
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusions
{
	/// <summary>
	/// Custom VPN exclusion rules. Pass an empty array to clear existing rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "custom")]
	public List<TrafficShapingVpnExclusionsCustom>? Custom { get; set; }

	/// <summary>
	/// Major Application based VPN exclusion rules. Pass an empty array to clear existing rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "majorApplications")]
	public List<TrafficShapingVpnExclusionsMajorApplication>? MajorApplications { get; set; }
}
