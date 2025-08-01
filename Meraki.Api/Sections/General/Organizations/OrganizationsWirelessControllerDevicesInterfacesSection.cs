﻿namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsWirelessControllerDevicesInterfacesSection
{
	public IOrganizationsWirelessControllerDevicesInterfacesL2 L2 { get; internal set; } = null!;

	public IOrganizationsWirelessControllerDevicesInterfacesL3 L3 { get; internal set; } = null!;

	public IOrganizationsWirelessControllerDevicesInterfacesPackets Packets { get; internal set; } = null!;

	public IOrganizationsWirelessControllerDevicesInterfacesUsage Usage { get; internal set; } = null!;
}