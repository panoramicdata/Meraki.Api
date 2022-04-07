namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSwitchSettingsDhcpServerPolicy
/// </summary>
[DataContract]
public class DhcpServerPolicy
{
	/// <summary>
	/// 'allow' or 'block' new DHCP servers. Default value is 'allow'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultPolicy")]
	public DefaultPolicy DefaultPolicy { get; set; }

	/// <summary>
	/// List the MAC addresses of DHCP servers to permit on the network. Applicable only if defaultPolicy is set to block. An empty array will clear the entries.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedServers")]
	public List<string> AllowedServers { get; set; } = new();

	/// <summary>
	/// List the MAC addresses of DHCP servers to block on the network. Applicable only if defaultPolicy is set to allow. An empty array will clear the entries.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "blockedServers")]
	public List<string> BlockedServers { get; set; } = new();

	/// <summary>
	/// additional information/config options for things like alerts/arp inspection
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "alerts")]
	public DhcpServerPolicyAlerts Alerts { get; set; } = new();


}
