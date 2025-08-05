namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Redundancy Failover History
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyFailoverHistory
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesRedundancyFailoverHistoryMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller HA failover events
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesRedundancyFailoverHistoryItem> Items { get; set; } = [];
}
