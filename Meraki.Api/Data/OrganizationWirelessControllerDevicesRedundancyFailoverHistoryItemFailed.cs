namespace Meraki.Api.Data;

/// <summary>
/// Details about the failed unit
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyFailoverHistoryItemFailed
{
	/// <summary>
	/// Details about the active unit chassis
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "chassis")]
	public OrganizationWirelessControllerDevicesRedundancyFailoverHistoryItemChassis Chassis { get; set; } = new();
}
