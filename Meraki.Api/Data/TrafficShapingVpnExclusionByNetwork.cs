namespace Meraki.Api.Data;

/// <summary>
/// TrafficShapingVpnExclusionByNetwork
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusionByNetwork : TrafficShapingVpnExclusions
{
	/// <summary>
	/// Network Id
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Network Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkName")]
	public string? NetworkName { get; set; }
}
