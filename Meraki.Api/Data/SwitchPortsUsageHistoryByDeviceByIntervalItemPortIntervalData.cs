namespace Meraki.Api.Data;

/// <summary>
/// A breakdown of how many kilobytes have passed through this port during the interval timespan.
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalData
{
	/// <summary>
	/// Usage data for the given interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalDataUsage Usage { get; set; } = new();

}
