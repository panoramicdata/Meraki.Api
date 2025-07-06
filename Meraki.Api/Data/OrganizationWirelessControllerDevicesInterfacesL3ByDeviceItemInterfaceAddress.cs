namespace Meraki.Api.Data;

/// <summary>
/// Available address for the interface.
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterfaceAddress
{
	/// <summary>
	/// The address of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Type of address for the device uplink. Available options are: ipv4, ipv6.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public IpProtocolType Protocol { get; set; }

	/// <summary>
	/// The address of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;
}
