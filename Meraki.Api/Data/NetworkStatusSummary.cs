namespace Meraki.Api.Data;

/// <summary>
/// Network Status Summary
/// </summary>
[DataContract]
public class NetworkStatusSummary
{
	/// <summary>
	/// Network name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Network identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Network clients list URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Product types in network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public List<string> ProductTypes { get; set; } = [];

	/// <summary>
	/// Network tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Network clients data
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clients")]
	public NetworkStatusSummaryClients Clients { get; set; } = new();

	/// <summary>
	/// Network device information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public NetworkStatusSummaryDevices Devices { get; set; } = new();

	/// <summary>
	/// Network device statuses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "statuses")]
	public NetworkStatusSummaryStatuses Statuses { get; set; } = new();
}
