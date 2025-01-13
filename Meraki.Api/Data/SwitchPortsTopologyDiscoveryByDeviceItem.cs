namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Topology Discover By Device Item
/// </summary>
[DataContract]
public class SwitchPortsTopologyDiscoveryByDeviceItem
{
	/// <summary>
	/// The MAC address of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The model of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// The name of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The serial number of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Identifying information of the switch's network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public SwitchPortsTopologyDiscoveryByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// The number of ports on the switch with usage data.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<SwitchPortsTopologyDiscoveryByDeviceItemPort> Ports { get; set; } = [];

}
