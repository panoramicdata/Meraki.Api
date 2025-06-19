namespace Meraki.Api.Data;

/// <summary>
/// The usage data on the interface of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItemIntervalByInterfaceItem
{
	/// <summary>
	/// The name of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The usage on the interfaces of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItemIntervalByInterfaceItemUsage Usage { get; set; } = new();
}
