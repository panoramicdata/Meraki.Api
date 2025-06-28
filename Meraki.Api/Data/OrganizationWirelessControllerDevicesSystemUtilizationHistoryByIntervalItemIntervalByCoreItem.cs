namespace Meraki.Api.Data;

/// <summary>
/// A CPU usage item per core of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalByCoreItem
{
	/// <summary>
	/// The CPU core name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The specific core CPU usage of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemIntervalByCoreItemUsage Usage { get; set; } = new();
}