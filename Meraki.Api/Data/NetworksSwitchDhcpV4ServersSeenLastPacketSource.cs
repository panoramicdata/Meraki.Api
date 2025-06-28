namespace Meraki.Api.Data;

/// <summary>
/// Source of the packet.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastPacketSource
{
	/// <summary>
	/// Source port of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public int Port { get; set; }

	/// <summary>
	/// Source mac address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Source ipv4 attributes of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketSourceIpv4 Ipv4 { get; set; } = new();
}
