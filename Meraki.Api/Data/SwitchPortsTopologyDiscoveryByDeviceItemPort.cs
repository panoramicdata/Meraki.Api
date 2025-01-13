namespace Meraki.Api.Data;

/// <summary>
/// SwitchPortsTopologyDiscoveryByDeviceItemPort
/// </summary>
[DataContract]
public class SwitchPortsTopologyDiscoveryByDeviceItemPort
{
	/// <summary>
	/// Timestamp for most recent discovery info on this port.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "latUpdatedAt")]
	public DateTime LastUpdatedAt { get; set; }

	/// <summary>
	/// The string identifier of this port on the switch. This is commonly just the port number but may contain 
	/// additional identifying information such as the slot and module-type if the port is located on a port module.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// The Cisco Discovery Protocol (CDP) information of the connected device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cdp")]
	public SwitchPortsTopologyDiscoveryByDeviceItemPortCdp Cdp { get; set; } = new();

	/// <summary>
	/// The Link Layer Discovery Protocol (LLDP) information of the connected device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lldp")]
	public SwitchPortsTopologyDiscoveryByDeviceItemPortCdp Lldp { get; set; } = new();
}
