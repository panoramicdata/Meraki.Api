namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Redundancy Statuses
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyStatuses
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesRedundancyStatusesMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller redundancy statuses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesRedundancyStatusesItem> Items { get; set; } = [];
}
