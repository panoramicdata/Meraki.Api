namespace Meraki.Api.Data;

/// <summary>
/// A breakdown of the average speed of data that has passed through this port during the interval.
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalBandwidth
{
	/// <summary>
	/// Bandwidth usage data for the given interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalBandwidthUsage Usage { get; set; } = new();

}
