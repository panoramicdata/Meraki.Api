﻿namespace Meraki.Api.Data;

/// <summary>
/// Interface belongs to the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceItemInterface
{
	/// <summary>
	/// The name of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The status of packets counter on the interfaces of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "readings")]
	public List<OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceItemInterfaceReading> Readings { get; set; } = [];
}
