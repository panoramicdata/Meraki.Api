namespace Meraki.Api.Data;

/// <summary>
/// SpeedBurst settings for appliance traffic shaping - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class TrafficShapingSpeedBurst
{
	/// <summary>
	/// Whether SpeedBurst is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
