namespace Meraki.Api.Data;

/// <summary>
/// Traffic shaping
/// </summary>
[DataContract]
public class TrafficShaping
{
	/// <summary>
	/// Global per-client bandwidth limit
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "globalBandwidthLimits")]
	public GlobalBandwidthLimit GlobalBandwidthLimits { get; set; } = new();

	/// <summary>
	/// SpeedBurst settings. Undocumented property, observed in live API responses only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speedBurst")]
	public TrafficShapingSpeedBurst? SpeedBurst { get; set; }
}
