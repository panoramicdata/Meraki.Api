namespace Meraki.Api.Data;

/// <summary>
/// The specific core CPU usage of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalByCoreItemUsage
{
	/// <summary>
	/// The specific core average CPU usage of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalByCoreItemUsageAverage Average { get; set; } = new();
}
