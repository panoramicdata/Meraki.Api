namespace Meraki.Api.Data;

/// <summary>
/// Ssid Usage Summary
/// </summary>
[DataContract]
public class SsidUsageSummary
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

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
