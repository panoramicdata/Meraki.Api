namespace Meraki.Api.Data;

/// <summary>
/// Destination of the packet.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastPacketDestination
{
	/// <summary>
	/// Destination port of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public int Port { get; set; }

	/// <summary>
	/// Destination mac address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Destination ipv4 attributes of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketDestinationIpv4 Ipv4 { get; set; } = new();
}
