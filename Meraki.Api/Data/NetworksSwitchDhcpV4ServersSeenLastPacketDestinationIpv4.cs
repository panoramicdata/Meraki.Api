namespace Meraki.Api.Data;

/// <summary>
/// Destination ipv4 attributes of the packet.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastPacketDestinationIpv4
{
	/// <summary>
	/// Destination ipv4 address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;
}