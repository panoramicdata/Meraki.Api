namespace Meraki.Api.Data;
/// <summary>
/// Uplink Wan Pppoe Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsInterfacesWanVlanTagging
{
	/// <summary>
	/// Whether VLAN tagging is enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// The ID of the VLAN to use for VLAN tagging.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanId")]
	public int? VlanId { get; set; }
}