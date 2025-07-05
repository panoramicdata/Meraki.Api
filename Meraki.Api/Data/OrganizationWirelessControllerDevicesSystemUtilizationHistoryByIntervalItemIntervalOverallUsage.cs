namespace Meraki.Api.Data;

/// <summary>
/// The CPU usage of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalOverallUsage
{
	/// <summary>
	/// The average CPU usage of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalOverallUsageAverage Average { get; set; } = new();
}
