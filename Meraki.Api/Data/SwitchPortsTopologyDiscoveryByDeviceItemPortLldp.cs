namespace Meraki.Api.Data;

/// <summary>
/// SwitchPortsTopologyDiscoveryByDeviceItemPortLldp
/// </summary>
[DataContract]
public class SwitchPortsTopologyDiscoveryByDeviceItemPortLldp
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
