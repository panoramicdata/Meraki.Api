namespace Meraki.Api.Data;

/// <summary>
/// SwitchPortsTopologyDiscoveryByDeviceItemPortCdp
/// </summary>
[DataContract]
public class SwitchPortsTopologyDiscoveryByDeviceItemPortCdp
{
	/// <summary>
	/// CDP RFC/official name of TLV
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
