namespace Meraki.Api.Data;

/// <summary>
/// TrafficShapingVpnExclusionsByNetwork
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusionsByNetworkResponse
{
	/// <summary>
	/// items
	/// </summary>
	[DataMember(Name = "items")]
	public List<TrafficShapingVpnExclusionsByNetwork>? Items { get; set; }
}
