namespace Meraki.Api.Data;

/// <summary>
/// Switch
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTopologyDiscoveryByDeviceItem
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
	[ApiAccess(ApiAccess.ReadWrite)]
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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationSwitchPortsTopologyDiscoveryByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Ports belonging to the switch with LLDP/CDP discovery info.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ports")]
	public List<OrganizationSwitchPortsTopologyDiscoveryByDeviceItemPort> Ports { get; set; } = [];
}
