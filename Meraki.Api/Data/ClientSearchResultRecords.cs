namespace Meraki.Api.Data;

[DataContract]

public class ClientSearchResultRecords
{
	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public Network Network { get; set; } = new();

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// OS
	/// </summary>
	[DataMember(Name = "os")]
	public string Os { get; set; } = string.Empty;

	/// <summary>
	/// User
	/// </summary>
	[DataMember(Name = "user")]
	public string User { get; set; } = string.Empty;

	/// <summary>
	/// IP
	/// </summary>
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// IP6
	/// </summary>
	[DataMember(Name = "ip6")]
	public string Ip6 { get; set; } = string.Empty;

	/// <summary>
	/// First seen
	/// </summary>
	[DataMember(Name = "firstSeen")]
	public int FirstSeen { get; set; }

	/// <summary>
	/// Last seen
	/// </summary>
	[DataMember(Name = "lastSeen")]
	public int LastSeen { get; set; }

	/// <summary>
	/// VLAN
	/// </summary>
	[DataMember(Name = "vlan")]
	public string Vlan { get; set; } = string.Empty;

	/// <summary>
	/// Switchport
	/// </summary>
	[DataMember(Name = "switchport")]
	public string Switchport { get; set; } = string.Empty;

	/// <summary>
	/// Wireless capabilities
	/// </summary>
	[DataMember(Name = "wirelessCapabilities")]
	public string WirelessCapabilities { get; set; } = string.Empty;

	/// <summary>
	/// SM installed
	/// </summary>
	[DataMember(Name = "smInstalled")]
	public bool SmInstalled { get; set; }

	/// <summary>
	/// SSID
	/// </summary>
	[DataMember(Name = "ssid")]
	public string Ssid { get; set; } = string.Empty;

	/// <summary>
	/// Client vpn connections
	/// </summary>
	[DataMember(Name = "clientVpnConnections")]
	public List<ClientVpnConnections> ClientVpnConnections { get; set; } = [];

	/// <summary>
	/// Lldp
	/// </summary>
	[DataMember(Name = "lldp")]
	public List<List<string>> Lldp { get; set; } = [];

	/// <summary>
	/// CDP
	/// </summary>
	[DataMember(Name = "cdp")]
	public string Cdp { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The MAC address of the node that the device was last connected to
	/// </summary>
	[DataMember(Name = "recentDeviceMac")]
	public string RecentDeviceMac { get; set; } = string.Empty;
}
