namespace Meraki.Api.Data;

/// <summary>
/// OSPF v3 configuration
/// </summary>
[DataContract]
public class RoutingOspfV3
{
	/// <summary>
	/// Time interval to determine when the peer will be declared inactive/dead. Value must be between 1 and 65535
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "deadTimerInSeconds")]
	public int? DeadTimerInSeconds { get; set; }

	/// <summary>
	/// Time interval in seconds at which hello packet will be sent to OSPF neighbors to maintain connectivity. Value must be between 1 and 255. Default is 10 seconds.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "helloTimerInSeconds")]
	public int? HelloTimerInSeconds { get; set; }

	/// <summary>
	/// Boolean value to enable or disable V3 OSPF routing. OSPF V3 routing is disabled by default.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// OSPF v3 areas
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "areas")]
	public List<Area>? Areas { get; set; }
}

