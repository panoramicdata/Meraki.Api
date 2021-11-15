using System.Runtime.Serialization;

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
	public int Mbps { get; set; } = 0;

	/// <summary>
	/// Metric
	/// </summary>
	[DataMember(Name = "metric")]
	public int Metric { get; set; } = 0;

	/// <summary>
	/// Usage percentage
	/// </summary>
	[DataMember(Name = "usagePercentage")]
	public string UsagePercentage { get; set; } = string.Empty;
}
