namespace Meraki.Api.Data;

/// <summary>
/// Usage data for the given interval.
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalDataUsage
{
	/// <summary>
	/// The amount of data received (in kilobytes).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downstream")]
	public double Downstream { get; set; }

	/// <summary>
	/// The total amount of data sent and received (in kilobytes).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public double Total { get; set; }

	/// <summary>
	/// The amount of data sent (in kilobytes).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upstream")]
	public double Upstream { get; set; }
}
