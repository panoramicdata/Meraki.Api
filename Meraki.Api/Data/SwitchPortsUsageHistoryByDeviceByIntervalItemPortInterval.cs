namespace Meraki.Api.Data;

/// <summary>
/// An interval for a port with bandwidth, traffic, and power usage data.
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemPortInterval
{
	/// <summary>
	/// The end timestamp of the given interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// The starting timestamp of the given interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// A breakdown of the average speed of data that has passed through this port during the interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bandwidth")]
	public SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalBandwidth Bandwidth { get; set; } = new();

	/// <summary>
	/// A breakdown of how many kilobytes have passed through this port during the interval timespan.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "data")]
	public SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalData Data { get; set; } = new();

	/// <summary>
	/// How much energy (in watt-hours) has been delivered by this port during the interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "energy")]
	public SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalEnergy Energy { get; set; } = new();
}
