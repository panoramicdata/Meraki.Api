namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceTrafficShapingVpnExclusionsUpdateResponse
/// </summary>
[DataContract]
public class NetworkApplianceTrafficShapingVpnExclusionsUpdateResponse
{
	/// <summary>
	/// ID of the network whose VPN exclusion rules are returned.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Name of the network whose VPN exclusion rules are returned.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networkName")]
	public string NetworkName { get; set; } = string.Empty;

	/// <summary>
	/// Custom VPN exclusion rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "custom")]
	public List<NetworkApplianceTrafficShapingVpnExclusionsCustomRule> Custom { get; set; } = new();

	/// <summary>
	/// Major Application based VPN exclusion rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "majorApplications")]
	public List<NetworkApplianceTrafficShapingVpnExclusionsMajorApplicationRule> MajorApplications { get; set; } = new();
}
