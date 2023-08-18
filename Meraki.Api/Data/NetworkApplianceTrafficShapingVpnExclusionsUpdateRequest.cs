namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceTrafficShapingVpnExclusionsUpdateRequest
/// </summary>
[DataContract]
public class NetworkApplianceTrafficShapingVpnExclusionsUpdateRequest
{
	/// <summary>
	/// Custom VPN exclusion rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "custom")]
	public List<NetworkApplianceTrafficShapingVpnExclusionsCustomRule> Custom { get; set; } = new();

	/// <summary>
	/// Major Application based VPN exclusion rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "majorApplications")]
	public List<NetworkApplianceTrafficShapingVpnExclusionsMajorApplicationRule> MajorApplications { get; set; } = new();
}
