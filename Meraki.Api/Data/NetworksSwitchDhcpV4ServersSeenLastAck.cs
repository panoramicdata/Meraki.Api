namespace Meraki.Api.Data;

/// <summary>
/// Attributes of the server's last ack.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastAck
{
	/// <summary>
	/// Last time the server was acked.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// IPv4 attributes of the last ack.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4")]
	public NetworksSwitchDhcpV4ServersSeenLastAckIpv4 Ipv4 { get; set; } = new();
}
