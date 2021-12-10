namespace Meraki.Api.Data;

/// <summary>
/// Latest mesh performance
/// </summary>
[DataContract]
public class LatestMeshPerformance
{
	/// <summary>
	/// Mbps
	/// </summary>
	[DataMember(Name = "mbps")]
	public int Mbps { get; set; }

	/// <summary>
	/// Metric
	/// </summary>
	[DataMember(Name = "metric")]
	public int Metric { get; set; }

	/// <summary>
	/// Usage percentage
	/// </summary>
	[DataMember(Name = "usagePercentage")]
	public string UsagePercentage { get; set; } = string.Empty;
}
