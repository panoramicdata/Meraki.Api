namespace Meraki.Api.Data;

/// <summary>
/// The Link Layer Discovery Protocol (LLDP) information of the connected device.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTopologyDiscoveryByDeviceItemPortLldpItem
{
	/// <summary>
	/// LLDP RFC/official name of TLV
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Value of the named TLV.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}