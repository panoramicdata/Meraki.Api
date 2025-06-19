namespace Meraki.Api.Data;

/// <summary>
/// Number of dropped packets, broken down by protocol
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCountsByProtocol
{
	/// <summary>
	/// Number of Address Resolution Protocol (ARP) packets dropped during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "arp")]
	public int Arp { get; set; }

	/// <summary>
	/// Number of Link Aggregation Control Protocol (LACP) packets dropped during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lacp")]
	public int Lacp { get; set; }

	/// <summary>
	/// Number of Internet Protocol (IPv4 and IPv6) packets dropped during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "management")]
	public int Management { get; set; }

	/// <summary>
	/// Number of Open Shortest Path First (OSFP) packets dropped during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ospf")]
	public int Ospf { get; set; }

	/// <summary>
	/// Number of Spanning Tree Protocol (STP) packets dropped during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "stp")]
	public int Stp { get; set; }
}