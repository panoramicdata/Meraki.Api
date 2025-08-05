namespace Meraki.Api.Data;

/// <summary>
/// Additional IP attributes of the packet.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastPacketIp
{
	/// <summary>
	/// IP header length of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "headerLength")]
	public int HeaderLength { get; set; }

	/// <summary>
	/// IP length of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "length")]
	public int Length { get; set; }

	/// <summary>
	/// IP protocol number of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public int Protocol { get; set; }

	/// <summary>
	/// Time to live of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ttl")]
	public int Ttl { get; set; }

	/// <summary>
	/// IP version of the packet. enum = [4, 6]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "version")]
	public int Version { get; set; }

	/// <summary>
	/// IP ID of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// DSCP attributes of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dscp")]
	public NetworksSwitchDhcpV4ServersSeenLastPacketIpDscp Dscp { get; set; } = new();
}
