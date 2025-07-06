namespace Meraki.Api.Data;

/// <summary>
/// Time interval snapshots of system memory utilization on the device with the most recent snapshot first
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemInterval
{
	/// <summary>
	/// Timestamp for the end of the historical snapshot, inclusive.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp for the beginning of the historical snapshot, exclusive.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Information regarding memory usage and availability on the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "memory")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemIntervalMemory Memory { get; set; } = new();
}
