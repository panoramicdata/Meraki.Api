namespace Meraki.Api.Data;

/// <summary>
/// Port belonging to the switch with LLDP/CDP discovery info.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTopologyDiscoveryByDeviceItemPort
{
	/// <summary>
	/// Timestamp for most recent discovery info on this port.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public string LastUpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// The string identifier of this port on the switch. This is commonly just the port number but may contain additional identifying information such as the slot and module-type if the port is located on a port module.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// The Cisco Discovery Protocol (CDP) information of the connected device.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "cdp")]
	public List<OrganizationSwitchPortsTopologyDiscoveryByDeviceItemPortCdpItem> Cdp { get; set; } = [];

	/// <summary>
	/// The Link Layer Discovery Protocol (LLDP) information of the connected device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lldp")]
	public List<OrganizationSwitchPortsTopologyDiscoveryByDeviceItemPortLldpItem> Lldp { get; set; } = [];
}
