namespace Meraki.Api.Data;

/// <summary>
/// Client Usage Summary
/// </summary>
[DataContract]

public class ClientUsageSummary
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

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
}
