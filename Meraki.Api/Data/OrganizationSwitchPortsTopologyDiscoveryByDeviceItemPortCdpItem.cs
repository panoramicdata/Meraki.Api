namespace Meraki.Api.Data;

/// <summary>
/// The Cisco Discovery Protocol (CDP) information of the connected device.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTopologyDiscoveryByDeviceItemPortCdpItem
{
	/// <summary>
	/// CDP RFC/official name of TLV
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Value of the named TLV.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}