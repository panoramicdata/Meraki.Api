namespace Meraki.Api.Data;

/// <summary>
/// TrafficShapingVpnExclusionsByNetwork
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusionsByNetwork
{
	/// <summary>
	/// items
	/// </summary>
	[DataMember(Name = "items")]
	public List<TrafficShapingVpnExclusionByNetwork>? Items { get; set; }

}
