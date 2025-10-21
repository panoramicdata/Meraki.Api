namespace Meraki.Api.Data;

/// <summary>
/// Item counts for paginated wireless MQTT settings response
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsResponseMetaCountsItems
{
	/// <summary>
	/// The total number of items in the dataset
	/// </summary>
	[DataMember(Name = "total")]
	public int? Total { get; set; }

	/// <summary>
	/// The number of items in the dataset that are available on subsequent pages
	/// </summary>
	[DataMember(Name = "remaining")]
	public int? Remaining { get; set; }
}
