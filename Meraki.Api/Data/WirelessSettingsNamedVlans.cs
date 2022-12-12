namespace Meraki.Api.Data;

/// <summary>
/// Wireless settings Named Vlans
/// </summary>
[DataContract]
public class WirelessSettingsNamedVlans
{
	/// <summary>
	/// Pool DHCP Monitoring
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "poolDhcpMonitoring")]
	public WirelessSettingsNamedVlansPoolDhcpMonitoring? PoolDhcpMonitoring { get; set; }
}
