namespace Meraki.Api.Data;

/// <summary>
/// IPv4 attributes of the last ack.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastAckIpv4
{
	/// <summary>
	/// IPv4 address of the last ack.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;
}