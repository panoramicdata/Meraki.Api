namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationNetwork
/// </summary>
[DataContract]
public class NetworkCreationRequest
{
	/// <summary>
	/// The name of the new network
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// A list of tags to be applied to the network
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// The timezone of the network. For a list of allowed timezones, please see the 'TZ' column in the table in this article https://en.wikipedia.org/wiki/List_of_tz_database_time_zone
	/// </summary>
	[DataMember(Name = "timeZone")]
	public string? TimeZone { get; set; }

	/// <summary>
	/// The ID of the network to copy configuration from. Other provided parameters will override the copied configuration, except type which must match this network's type exactly.
	/// </summary>
	[DataMember(Name = "copyFromNetworkId")]
	public string? CopyFromNetworkId { get; set; }

	/// <summary>
	/// The product type(s) of the new network. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, sensor, environmental. If more than one type is included, the network will be a combined network.
	/// </summary>
	[DataMember(Name = "productTypes")]
	public List<ProductType> ProductTypes { get; set; } = new();

	/// <summary>
	/// Add any notes or additional information about this network here.
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }
}
