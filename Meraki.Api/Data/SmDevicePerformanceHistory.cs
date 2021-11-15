namespace Meraki.Api.Data;

/// <summary>
/// Performance history
/// </summary>
[DataContract]
public class SmDevicePerformanceHistory
{
	/// <summary>
	/// CPU percent used
	/// </summary>
	[DataMember(Name = "cpuPercentUsed")]
	public int CpuPercentUsed { get; set; }

	/// <summary>
	/// Memory free
	/// </summary>
	[DataMember(Name = "memFree")]
	public int MemFree { get; set; }

	/// <summary>
	/// Memory wired
	/// </summary>
	[DataMember(Name = "memWired")]
	public int MemWired { get; set; }

	/// <summary>
	/// Memory active
	/// </summary>
	[DataMember(Name = "memActive")]
	public int MemActive { get; set; }

	/// <summary>
	/// Memory inactive
	/// </summary>
	[DataMember(Name = "memInactive")]
	public int MemInactive { get; set; }

	/// <summary>
	/// Network sent
	/// </summary>
	[DataMember(Name = "networkSent")]
	public int NetworkSent { get; set; }

	/// <summary>
	/// Network received
	/// </summary>
	[DataMember(Name = "networkReceived")]
	public int NetworkReceived { get; set; }

	/// <summary>
	/// Swap used
	/// </summary>
	[DataMember(Name = "swapUsed")]
	public int SwapUsed { get; set; }

	/// <summary>
	/// Disk usage
	/// </summary>
	[DataMember(Name = "diskUsage")]
	public DiskUsage DiskUsage { get; set; } = new();

	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;
}
