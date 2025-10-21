namespace Meraki.Api.Data;

/// <summary>
/// Counts for paginated wireless MQTT settings response
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsResponseMetaCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[DataMember(Name = "items")]
	public OrganizationWirelessMqttSettingsResponseMetaCountsItems? Items { get; set; }
}
