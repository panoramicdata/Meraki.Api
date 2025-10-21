namespace Meraki.Api.Data;

/// <summary>
/// Request model for updating organization wireless MQTT settings
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsUpdateRequest
{
	/// <summary>
	/// MQTT settings
	/// </summary>
	[DataMember(Name = "mqtt")]
	public OrganizationWirelessMqttSettingsMqtt? Mqtt { get; set; }

	/// <summary>
	/// BLE settings
	/// </summary>
	[DataMember(Name = "ble")]
	public OrganizationWirelessMqttSettingsBle? Ble { get; set; }

	/// <summary>
	/// Wi-Fi settings
	/// </summary>
	[DataMember(Name = "wifi")]
	public OrganizationWirelessMqttSettingsWifi? Wifi { get; set; }
}
