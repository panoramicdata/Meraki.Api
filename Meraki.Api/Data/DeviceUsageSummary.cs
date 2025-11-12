namespace Meraki.Api.Data;

/// <summary>
/// Device Usage Summary
/// </summary>
[DataContract]
public class DeviceUsageSummary
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Model
	/// </summary>
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Product type
	/// </summary>
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;

	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public ApplianceUtilizationSummaryNetwork Network { get; set; } = new();

	/// <summary>
	/// Usage
	/// </summary>
	[DataMember(Name = "usage")]
	public ClientOverviewUsageOverall Usage { get; set; } = new();

	/// <summary>
	/// Clients
	/// </summary>
	[DataMember(Name = "clients")]
	public ClientManufacturersSummaryClients Clients { get; set; } = new();
}
