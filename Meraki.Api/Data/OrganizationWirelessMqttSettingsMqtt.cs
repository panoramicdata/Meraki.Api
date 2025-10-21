namespace Meraki.Api.Data;

/// <summary>
/// MQTT settings for wireless MQTT
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsMqtt
{
	/// <summary>
	/// Settings ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "settingsId")]
	public string? SettingsId { get; set; }

	/// <summary>
	/// MQTT Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// MQTT Topic
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "topic")]
	public string? Topic { get; set; }

	/// <summary>
	/// Message fields to include
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "messageFields")]
	public List<string>? MessageFields { get; set; }

	/// <summary>
	/// Publishing settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "publishing")]
	public OrganizationWirelessMqttSettingsMqttPublishing? Publishing { get; set; }

	/// <summary>
	/// Broker information
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "broker")]
	public OrganizationWirelessMqttSettingsMqttBroker? Broker { get; set; }
}
