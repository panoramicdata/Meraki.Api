namespace Meraki.Api.Data;

/// <summary>
/// Custom performance classes
/// </summary>
[DataContract]
public class CustomPerformanceClass
{
	/// <summary>
	/// Custom performance class id
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "customPerformanceClassId")]
	public string CustomPerformanceClassId { get; set; } = string.Empty;

	/// <summary>
	/// Name of the custom performance class
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Maximum latency in milliseconds
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "maxLatency")]
	public int MaxLatency { get; set; }

	/// <summary>
	/// Maximum jitter in milliseconds
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "maxJitter")]
	public int MaxJitter { get; set; }

	/// <summary>
	/// Maximum percentage of packet loss
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "maxLossPercentage")]
	public int MaxLossPercentage { get; set; }
}
