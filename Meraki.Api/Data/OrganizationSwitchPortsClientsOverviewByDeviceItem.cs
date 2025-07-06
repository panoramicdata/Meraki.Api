namespace Meraki.Api.Data;

/// <summary>
/// Switches
/// </summary>
[DataContract]
public class OrganizationSwitchPortsClientsOverviewByDeviceItem
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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationSwitchPortsClientsOverviewByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// The number of online clients of the ports on the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<OrganizationSwitchPortsClientsOverviewByDeviceItemPort> Ports { get; set; } = [];
}
