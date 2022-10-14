namespace Meraki.Api.Data;
/// <summary>
/// Uplink Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsInterfaces
{
	/// <summary>
	/// WAN 1 Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wan1")]
	public DeviceApplianceUplinkSettingsInterfacesWan? Wan1 { get; set; }

	/// <summary>
	/// WAN 2 Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wan2")]
	public DeviceApplianceUplinkSettingsInterfacesWan? Wan2 { get; set; }
}