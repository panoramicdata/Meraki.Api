namespace Meraki.Api.Data;

/// <summary>
/// Additional ethernet attributes of the packet.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastPacketEthernet
{
	/// <summary>
	/// Ethernet type of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}