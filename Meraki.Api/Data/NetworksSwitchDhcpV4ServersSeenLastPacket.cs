namespace Meraki.Api.Data;

/// <summary>
/// Last packet the server received.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastPacket
{
	/// <summary>
	/// Packet type.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Destination of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destination")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketDestination Destination { get; set; } = new();

	/// <summary>
	/// Additional ethernet attributes of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ethernet")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketEthernet Ethernet { get; set; } = new();

	/// <summary>
	/// DHCP-specific fields of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fields")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketFields Fields { get; set; } = new();

	/// <summary>
	/// Additional IP attributes of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ip")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketIp Ip { get; set; } = new();

	/// <summary>
	/// Source of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketSource Source { get; set; } = new();

	/// <summary>
	/// UDP attributes of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "udp")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketUdp Udp { get; set; } = new();
}
