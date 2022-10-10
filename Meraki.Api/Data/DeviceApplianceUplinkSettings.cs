namespace Meraki.Api.Data;
/// <summary>
/// Uplink Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettings
{
	/// <summary>
	/// Interface Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "interfaces")]
	public DeviceApplianceUplinkSettingsInterfaces? Interfaces { get; set; }
}