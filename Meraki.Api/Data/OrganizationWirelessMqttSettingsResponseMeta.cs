namespace Meraki.Api.Data;

/// <summary>
/// Metadata for paginated wireless MQTT settings response
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsResponseMeta
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[DataMember(Name = "counts")]
	public OrganizationWirelessMqttSettingsResponseMetaCounts? Counts { get; set; }
}
