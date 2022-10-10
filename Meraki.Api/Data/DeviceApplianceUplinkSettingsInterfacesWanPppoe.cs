namespace Meraki.Api.Data;
/// <summary>
/// Uplink Wan Pppoe Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsInterfacesWanPppoe
{
	/// <summary>
	/// Whether PPPoE is enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Settings for PPPoE Authentication.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authentication")]
	public DeviceApplianceUplinkSettingsInterfacesWanPppoeAuthentication? Authentication { get; set; }
}