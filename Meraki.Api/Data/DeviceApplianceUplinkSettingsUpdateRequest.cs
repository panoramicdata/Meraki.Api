namespace Meraki.Api.Data;
/// <summary>
/// Uplink Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsUpdateRequest
{
	/// <summary>
	/// Interface Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaces")]
	public DeviceApplianceUplinkSettingsInterfaces? Interfaces { get; set; }
}