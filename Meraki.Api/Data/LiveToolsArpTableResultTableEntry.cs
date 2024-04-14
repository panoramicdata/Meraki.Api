namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Arp Table Result Table Entry
/// </summary>
[DataContract]

public class LiveToolsArpTableResultTableEntry
{
	/// <summary>
	/// The VLAN ID of the ARP table entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; }

	/// <summary>
	/// The IP address of the ARP table entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Time of the last update of the ARP table entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public DateTime LastUpdatedAt { get; set; }

	/// <summary>
	/// The MAC address of the ARP table entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;
}
