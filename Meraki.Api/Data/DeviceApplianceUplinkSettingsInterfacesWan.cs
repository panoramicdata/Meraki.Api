namespace Meraki.Api.Data;
/// <summary>
/// Uplink Wan Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsInterfacesWan
{
	/// <summary>
	/// Enable or disable the interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Configuration options for PPPoE
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "pppoe")]
	public DeviceApplianceUplinkSettingsInterfacesWanPppoe? Pppoe { get; set; }

	/// <summary>
	/// SVI settings by protocol.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "svis")]
	public DeviceApplianceUplinkSettingsInterfacesWanSvis? Svis { get; set; }

	/// <summary>
	/// VLAN tagging settings.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanTagging")]
	public DeviceApplianceUplinkSettingsInterfacesWanVlanTagging? VlanTagging { get; set; }
}