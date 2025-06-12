namespace Meraki.Api.Data;

/// <summary>
/// The average CPU usage of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalOverallUsageAverage
{
	/// <summary>
	/// The CPU usage percentage of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}