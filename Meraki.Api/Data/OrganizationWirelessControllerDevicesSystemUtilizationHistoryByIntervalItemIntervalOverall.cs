namespace Meraki.Api.Data;

/// <summary>
/// The overall CPU usage of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalOverall
{
	/// <summary>
	/// The CPU usage of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalOverallUsage Usage { get; set; } = new();
}
