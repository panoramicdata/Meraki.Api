namespace Meraki.Api.Data;

/// <summary>
/// MQTT publishing settings
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsMqttPublishing
{
	/// <summary>
	/// Publishing frequency in seconds
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "frequency")]
	public int? Frequency { get; set; }

	/// <summary>
	/// Quality of Service level (0, 1, or 2)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "qos")]
	public int? Qos { get; set; }
}
