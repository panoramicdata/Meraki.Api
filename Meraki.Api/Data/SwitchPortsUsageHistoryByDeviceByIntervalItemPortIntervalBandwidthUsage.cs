namespace Meraki.Api.Data;

/// <summary>
/// Bandwidth usage data for the given interval.
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalBandwidthUsage
{
	/// <summary>
	/// The average speed of the data received (in kilobits-per-second).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downstream")]
	public double Downstream { get; set; }

	/// <summary>
	/// The average speed of the data sent and received (in kilobits-per-second).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public double Total { get; set; }

	/// <summary>
	/// The average speed of the data sent (in kilobits-per-second).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upstream")]
	public double Upstream { get; set; }

}
