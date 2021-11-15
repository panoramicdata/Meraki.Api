using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// A client access statistic
/// </summary>
[DataContract]
public class ClientAccess
{
	/// <summary>
	/// Usage
	/// </summary>
	[DataMember(Name = "usage")]
	public Usage Usage { get; set; } = new Usage();

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = default!;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// The mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = default!;

	/// <summary>
	/// The IP address
	/// </summary>
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = default!;

	/// <summary>
	/// The user
	/// </summary>
	[DataMember(Name = "user")]
	public string User { get; set; } = default!;

	/// <summary>
	/// The VLAN
	/// </summary>
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// The switch port
	/// </summary>
	[DataMember(Name = "switchport")]
	public object Switchport { get; set; } = default!;

	/// <summary>
	/// The IPv6 address
	/// </summary>
	[DataMember(Name = "ip6")]
	public string Ip6 { get; set; } = default!;

	/// <summary>
	/// When this client was first seen
	/// </summary>
	[DataMember(Name = "firstSeen")]
	public int FirstSeen { get; set; }

	/// <summary>
	/// When this client was last seen
	/// </summary>
	[DataMember(Name = "lastSeen")]
	public int LastSeen { get; set; }

	/// <summary>
	/// The manufacturer
	/// </summary>
	[DataMember(Name = "manufacturer")]
	public string Manufacturer { get; set; } = default!;

	/// <summary>
	/// The Operating system
	/// </summary>
	[DataMember(Name = "os")]
	public string Os { get; set; } = default!;

	/// <summary>
	/// The recent device serial
	/// </summary>
	[DataMember(Name = "recentDeviceSerial")]
	public string RecentDeviceSerial { get; set; } = default!;

	/// <summary>
	/// The recent device name
	/// </summary>
	[DataMember(Name = "recentDeviceName")]
	public string RecentDeviceName { get; set; } = default!;

	/// <summary>
	/// The recent device mac address
	/// </summary>
	[DataMember(Name = "recentDeviceMac")]
	public string RecentDeviceMac { get; set; } = default!;

	/// <summary>
	/// The SSID
	/// </summary>
	[DataMember(Name = "ssid")]
	public string Ssid { get; set; } = default!;

	/// <summary>
	/// The status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = default!;
}
