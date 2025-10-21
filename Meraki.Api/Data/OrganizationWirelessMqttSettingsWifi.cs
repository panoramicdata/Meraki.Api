namespace Meraki.Api.Data;

/// <summary>
/// Wi-Fi settings for wireless MQTT
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsWifi
{
	/// <summary>
	/// Wi-Fi Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Wi-Fi client type. Valid types are: associated, visible
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Wi-Fi flush settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "flush")]
	public OrganizationWirelessMqttSettingsWifiFlush? Flush { get; set; }

	/// <summary>
	/// Allowed lists for MAC
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowLists")]
	public OrganizationWirelessMqttSettingsWifiAllowLists? AllowLists { get; set; }

	/// <summary>
	/// Wi-Fi hysteresis settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "hysteresis")]
	public OrganizationWirelessMqttSettingsWifiHysteresis? Hysteresis { get; set; }
}
