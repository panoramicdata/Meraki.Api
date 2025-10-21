namespace Meraki.Api.Data;

/// <summary>
/// BLE settings for wireless MQTT
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsBle
{
	/// <summary>
	/// BLE Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// BLE client type. Valid types are: ibeacon, eddystone
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// BLE flush settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "flush")]
	public OrganizationWirelessMqttSettingsBleFlush? Flush { get; set; }

	/// <summary>
	/// Allowed lists for UUID and MAC
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowLists")]
	public OrganizationWirelessMqttSettingsBleAllowLists? AllowLists { get; set; }

	/// <summary>
	/// BLE hysteresis settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "hysteresis")]
	public OrganizationWirelessMqttSettingsBleHysteresis? Hysteresis { get; set; }
}
