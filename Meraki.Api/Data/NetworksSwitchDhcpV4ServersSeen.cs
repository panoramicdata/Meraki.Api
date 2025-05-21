namespace Meraki.Api.Data;

/// <summary>
/// Networks Switch Dhcp V4 Servers Seen
/// </summary>
[DataContract]
public class NetworksSwitchDhcpV4ServersSeen
{
	/// <summary>
	/// Vlan id of the server.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// Client id of the server if available.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientId")]
	public string ClientId { get; set; } = string.Empty;

	/// <summary>
	/// Last time the server was seen.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastSeenAt")]
	public string LastSeenAt { get; set; } = string.Empty;

	/// <summary>
	/// Mac address of the server.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Server type. Can be a 'device', 'stack', or 'discovered' (i.e client).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public DhcpServerType Type { get; set; }

	/// <summary>
	/// Whether the server is allowed or blocked. Always true for configured servers.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isAllowed")]
	public bool IsAllowed { get; set; }

	/// <summary>
	/// Whether the server is configured.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isConfigured")]
	public bool IsConfigured { get; set; }

	/// <summary>
	/// Attributes of the server when it's a device.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "device")]
	public NetworksSwitchDhcpV4ServersSeenDevice Device { get; set; } = new();

	/// <summary>
	/// IPv4 attributes of the server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipv4")]
	public NetworksSwitchDhcpV4ServersSeenIpv4 Ipv4 { get; set; } = new();

	/// <summary>
	/// Attributes of the server's last ack.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lastAck")]
	public NetworksSwitchDhcpV4ServersSeenLastAck LastAck { get; set; } = new();

	/// <summary>
	/// Last packet the server received.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lastPacket")]
	public NetworksSwitchDhcpV4ServersSeenLastPacket LastPacket { get; set; } = new();

	/// <summary>
	/// Devices that saw the server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "seenBy")]
	public List<NetworksSwitchDhcpV4ServersSeenSeenByItem> SeenBy { get; set; } = [];
}
