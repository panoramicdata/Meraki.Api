namespace Meraki.Api.Data;

/// <summary>
/// Uplink selection
/// </summary>
[DataContract]
public class UplinkSelection
{
	/// <summary>
	/// Toggle for enabling or disabling active-active AutoVPN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "activeActiveAutoVpnEnabled")]
	public bool? ActiveActiveAutoVpnEnabled { get; set; }

	/// <summary>
	/// The default uplink. Must be a WAN interface 'wanX'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultUplink")]
	public string? DefaultUplink { get; set; }

	/// <summary>
	/// Toggle for enabling or disabling load balancing
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "loadBalancingEnabled")]
	public bool? LoadBalancingEnabled { get; set; }

	/// <summary>
	/// WAN failover and failback
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "failoverAndFailback")]
	public UplinkSelectionFailoverAndFailback? FailoverAndFailback { get; set; }

	/// <summary>
	/// Array of uplink preference rules for WAN traffic
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wanTrafficUplinkPreferences")]
	public List<TrafficUplinkPreference>? WanTrafficUplinkPreferences { get; set; }

	/// <summary>
	/// Array of uplink preference rules for VPN traffic
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vpnTrafficUplinkPreferences")]
	public List<TrafficUplinkPreference>? VpnTrafficUplinkPreferences { get; set; }
}
