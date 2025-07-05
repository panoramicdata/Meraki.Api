namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller interface packet status
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceItem
{
	/// <summary>
	/// The cloud ID of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Interfaces belongs to the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaces")]
	public List<OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceItemInterface> Interfaces { get; set; } = [];
}
