namespace Meraki.Api.Data;

/// <summary>
/// Layer 3 OSPF routing configuration
/// </summary>
[DataContract]
public class RoutingOspf
{
	/// <summary>
	/// Boolean value to enable or disable OSPF routing. OSPF routing is disabled by default.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Time interval in seconds at which hello packet will be sent to OSPF neighbors to maintain connectivity. Value must be between 1 and 255. Default is 10 seconds
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "helloTimerInSeconds")]
	public int? HelloTimerInSeconds { get; set; }

	/// <summary>
	/// Time interval to determine when the peer will be declare inactive/dead. Value must be between 1 and 65535
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "deadTimerInSeconds")]
	public int? DeadTimerInSeconds { get; set; }

	/// <summary>
	/// OSPF areas
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "areas")]
	public List<Area>? Areas { get; set; }

	/// <summary>
	/// OSPF v3 Configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "v3")]
	public RoutingOspfV3? V3 { get; set; }

	/// <summary>
	/// OSPF v3 Configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "v3")]
	public RoutingOspfV3? V3 { get; set; }

	/// <summary>
	/// OSPF v3 Configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "v3")]
	public RoutingOspfV3? V3 { get; set; }

	/// <summary>
	/// Boolean value to enable or disable MD5 authentication. MD5 authentication is disabled by default.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "md5AuthenticationEnabled")]
	public bool? Md5AuthenticationEnabled { get; set; }

	/// <summary>
	/// MD5 authentication credentials. This param is only relevant if md5AuthenticationEnabled is true
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "md5AuthenticationKey")]
	public Md5AuthenticationKey? Md5AuthenticationKey { get; set; }
}
