namespace Meraki.Api.Data;

/// <summary>
/// Number of dropped/processed packets, broken down by protocol
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMemberHistoryItemCountsByProtocol
{
	/// <summary>
	/// Number of Address Resolution Protocol (ARP) packets dropped/processed, during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "arp")]
	public int Arp { get; set; }

	/// <summary>
	/// Number of Internet Protocol (IPv4 and IPv6) packets dropped/processed, during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "management")]
	public int Management { get; set; }
}