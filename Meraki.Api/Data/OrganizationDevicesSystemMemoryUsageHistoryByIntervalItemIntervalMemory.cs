namespace Meraki.Api.Data;

/// <summary>
/// Information regarding memory usage and availability on the device
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemIntervalMemory
{
	/// <summary>
	/// Information regarding memory availability on the device over the interval
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "free")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemIntervalMemoryFree Free { get; set; } = new();

	/// <summary>
	/// Information regarding memory usage on the device over the interval
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "used")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemIntervalMemoryUsed Used { get; set; } = new();
}
