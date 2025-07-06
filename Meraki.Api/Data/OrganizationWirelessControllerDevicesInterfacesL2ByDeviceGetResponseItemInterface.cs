namespace Meraki.Api.Data;

/// <summary>
/// Layer 2 interface belonging to the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseItemInterface
{
	/// <summary>
	/// The VLAN of the switch port. For a trunk port, this is the native VLAN. A null value will clear the value set for trunk ports.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public string Vlan { get; set; } = string.Empty;

	/// <summary>
	/// The description of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The interface negotiation mode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "linkNegotiation")]
	public string LinkNegotiation { get; set; } = string.Empty;

	/// <summary>
	/// The MAC address of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The name of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The current data transfer rate which the interface is operating at. enum = [1 Gbps, 2 Gbps, 5 Gbps, 10 Gbps, 20 Gbps, 40 Gbps, 100 Gbps]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speed")]
	public string Speed { get; set; } = string.Empty;

	/// <summary>
	/// The status of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The status of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Indicate whether the interface is a redundancy port used to perform HA role negotiation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isRedundancyPort")]
	public bool IsRedundancyPort { get; set; }

	/// <summary>
	/// Indicate whether the interface is uplink
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isUplink")]
	public bool IsUplink { get; set; }

	/// <summary>
	/// The channel group of this wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "channelGroup")]
	public OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseItemInterfaceChannelGroup ChannelGroup { get; set; } = new();

	/// <summary>
	/// The module of this wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "module")]
	public OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseItemInterfaceModule Module { get; set; } = new();
}
