namespace Meraki.Api.Data;

/// <summary>
/// Paginated response for organization wireless MQTT settings
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsResponse
{
	/// <summary>
	/// List of wireless MQTT settings
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationWirelessMqttSettings>? Items { get; set; }

	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[DataMember(Name = "meta")]
	public OrganizationWirelessMqttSettingsResponseMeta? Meta { get; set; }
}
