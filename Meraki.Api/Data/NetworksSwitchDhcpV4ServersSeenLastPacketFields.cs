namespace Meraki.Api.Data;

/// <summary>
/// DHCP-specific fields of the packet.
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeenLastPacketFields
{
	/// <summary>
	/// Hardware length of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hlen")]
	public int Hlen { get; set; }

	/// <summary>
	/// Number of hops the packet took.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hops")]
	public int Hops { get; set; }

	/// <summary>
	/// Hardware type code of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "htype")]
	public int Htype { get; set; }

	/// <summary>
	/// Operation code of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "op")]
	public int Op { get; set; }

	/// <summary>
	/// Number of seconds since receiving the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "secs")]
	public int Secs { get; set; }

	/// <summary>
	/// Client hardware address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "chaddr")]
	public string Chaddr { get; set; } = string.Empty;

	/// <summary>
	/// Client IP address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ciaddr")]
	public string Ciaddr { get; set; } = string.Empty;

	/// <summary>
	/// Packet flags.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "flags")]
	public string Flags { get; set; } = string.Empty;

	/// <summary>
	/// Gateway IP address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "giaddr")]
	public string Giaddr { get; set; } = string.Empty;

	/// <summary>
	/// Magic cookie of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "magicCookie")]
	public string MagicCookie { get; set; } = string.Empty;

	/// <summary>
	/// Server IP address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "siaddr")]
	public string Siaddr { get; set; } = string.Empty;

	/// <summary>
	/// Server identifier address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sname")]
	public string Sname { get; set; } = string.Empty;

	/// <summary>
	/// Transaction id of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "xid")]
	public string Xid { get; set; } = string.Empty;

	/// <summary>
	/// Assigned IP address of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "yiaddr")]
	public string Yiaddr { get; set; } = string.Empty;

	/// <summary>
	/// Additional DHCP options of the packet.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "options")]
	public List<NetworksSwitchDhcpV4ServersSeenLastPacketFieldsOption> Options { get; set; } = [];
}
