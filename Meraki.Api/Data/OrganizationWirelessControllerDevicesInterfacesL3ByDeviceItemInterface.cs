namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller L3 interface
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterface
{
	/// <summary>
	/// The VLAN of the switch port. For a trunk port, this is the native VLAN. A null value will clear the value set for trunk ports.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

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
	public OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterfaceChannelGroup ChannelGroup { get; set; } = new();

	/// <summary>
	/// The module of this wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "module")]
	public OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterfaceModule Module { get; set; } = new();

	/// <summary>
	/// The virtual routing and forwarding (VRF) for the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vrf")]
	public OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterfaceVrf Vrf { get; set; } = new();

	/// <summary>
	/// Available addresses for the interface.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "addresses")]
	public List<OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterfaceAddress> Addresses { get; set; } = [];
}
