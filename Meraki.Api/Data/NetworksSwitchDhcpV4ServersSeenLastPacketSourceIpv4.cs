namespace Meraki.Api.Data;

/// <summary>
/// Source ipv4 attributes of the packet.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastPacketSourceIpv4
{
	/// <summary>
	/// Source ipv4 address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4")]
	public string Ipv4 { get; set; } = string.Empty;
}