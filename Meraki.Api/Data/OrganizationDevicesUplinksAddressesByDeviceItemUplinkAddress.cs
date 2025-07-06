namespace Meraki.Api.Data;

/// <summary>
/// An available address for the interface.
/// </summary>
[DataContract]
public class OrganizationDevicesUplinksAddressesByDeviceItemUplinkAddress
{
	/// <summary>
	/// Device uplink address.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Indicates how the device uplink address is assigned. Available options are: static, dynamic.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assignmentMode")]
	public AddressAssignmentMode AssignmentMode { get; set; }

	/// <summary>
	/// Device uplink gateway address.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gateway")]
	public string Gateway { get; set; } = string.Empty;

	/// <summary>
	/// Type of address for the device uplink. Available options are: ipv4, ipv6.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public IpProtocolType Protocol { get; set; }

	/// <summary>
	/// Device DNS nameserver information.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "nameservers")]
	public OrganizationDevicesUplinksAddressesByDeviceItemUplinkAddressNameservers Nameservers { get; set; } = new();

	/// <summary>
	/// Public interface information.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "public")]
	public OrganizationDevicesUplinksAddressesByDeviceItemUplinkAddressPublic Public { get; set; } = new();

	/// <summary>
	/// VLAN information of the uplink interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public OrganizationDevicesUplinksAddressesByDeviceItemUplinkAddressVlan Vlan { get; set; } = new();
}
