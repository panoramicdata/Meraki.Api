namespace Meraki.Api.Data;

[DataContract]
public class EnergyUsageSummary
{
	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public ApplianceUtilizationSummaryNetwork Network { get; set; } = new();

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
	/// Model
	/// </summary>
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Usage
	/// </summary>
	[DataMember(Name = "usage")]
	public ClientOverviewUsageOverall Usage { get; set; } = new();
}
