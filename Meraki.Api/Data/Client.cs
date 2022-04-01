namespace Meraki.Api.Data;

/// <summary>
/// A (Network) Client
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class Client : IdentifiedItem
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public new string Id { get; set; } = string.Empty;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// The mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = default!;

	/// <summary>
	/// The IP address
	/// </summary>
	[DataMember(Name = "ip")]
	public string? Ip { get; set; }

	/// <summary>
	/// The user
	/// </summary>
	[DataMember(Name = "user")]
	public string? User { get; set; }

	/// <summary>
	/// The VLAN
	/// </summary>
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// The switch port
	/// </summary>
	[DataMember(Name = "switchport")]
	public string? Switchport { get; set; }

	/// <summary>
	/// The IPv6 address
	/// </summary>
	[DataMember(Name = "ip6")]
	public string? Ip6 { get; set; }

	/// <summary>
	/// The IPv6 local address
	/// </summary>
	[DataMember(Name = "ip6Local")]
	public string? Ip6Local { get; set; }

	/// <summary>
	/// When this client was first seen
	/// </summary>
	[DataMember(Name = "firstSeen")]
	public DateTime FirstSeen { get; set; }

	/// <summary>
	/// When this client was last seen
	/// </summary>
	[DataMember(Name = "lastSeen")]
	public DateTime LastSeen { get; set; }

	/// <summary>
	/// The manufacturer
	/// </summary>
	[DataMember(Name = "manufacturer")]
	public string? Manufacturer { get; set; }

	/// <summary>
	/// The Operating system
	/// </summary>
	[DataMember(Name = "os")]
	public string? Os { get; set; }

	/// <summary>
	/// SSID
	/// </summary>
	[DataMember(Name = "ssid")]
	public string? Ssid { get; set; }

	/// <summary>
	/// Wireless capabilities
	/// </summary>
	[DataMember(Name = "wirelessCapabilities")]
	public string WirelessCapabilities { get; set; } = string.Empty;

	/// <summary>
	/// The recent device mac address
	/// </summary>
	[DataMember(Name = "recentDeviceMac")]
	public string RecentDeviceMac { get; set; } = default!;

	/// <summary>
	/// The status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = default!;

	/// <summary>
	/// The notes
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// SM Installed
	/// </summary>
	[DataMember(Name = "smInstalled")]
	public bool SmInstalled { get; set; } = default!;

	/// <summary>
	/// LLDP
	/// </summary>
	[DataMember(Name = "lldp")]
	public List<List<string>> Lldp { get; set; } = new();

	/// <summary>
	/// Client VPN connections
	/// </summary>
	[DataMember(Name = "clientVpnConnections")]
	public List<ClientVpnConnections> ClientVpnConnections { get; set; } = new();

	/// <summary>
	/// The groupPolicy8021x
	/// </summary>
	[DataMember(Name = "groupPolicy8021x")]
	public string? GroupPolicy8021x { get; set; }

	/// <summary>
	/// The adaptivePolicyGroup
	/// </summary>
	[DataMember(Name = "adaptivePolicyGroup")]
	public object? AdaptivePolicyGroup { get; set; }

	[DataMember(Name = "usage")]
	public UsageInKb Usage { get; set; } = new();
}
