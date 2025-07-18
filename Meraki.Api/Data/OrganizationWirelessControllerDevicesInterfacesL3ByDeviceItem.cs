﻿namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller L3 interface
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItem
{
	/// <summary>
	/// The cloud ID of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Layer 3 interfaces belongs to the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaces")]
	public List<OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterface> Interfaces { get; set; } = [];
}
