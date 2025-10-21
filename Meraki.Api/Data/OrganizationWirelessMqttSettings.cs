namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless MQTT Settings
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettings
{
	/// <summary>
	/// Network information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationWirelessMqttSettingsNetwork? Network { get; set; }

	/// <summary>
	/// MQTT settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mqtt")]
	public OrganizationWirelessMqttSettingsMqtt? Mqtt { get; set; }

	/// <summary>
	/// BLE settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ble")]
	public OrganizationWirelessMqttSettingsBle? Ble { get; set; }

	/// <summary>
	/// Wi-Fi settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wifi")]
	public OrganizationWirelessMqttSettingsWifi? Wifi { get; set; }
}
