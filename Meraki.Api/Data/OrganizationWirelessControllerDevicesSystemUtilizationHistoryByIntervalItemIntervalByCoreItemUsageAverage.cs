namespace Meraki.Api.Data;

/// <summary>
/// The specific core average CPU usage of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalByCoreItemUsageAverage
{
	/// <summary>
	/// The specific core CPU usage percentage of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}