namespace Meraki.Api.Data;

/// <summary>
/// Memory utilization percentages on the device over the interval
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemIntervalMemoryUsedPercentages
{
	/// <summary>
	/// Maximum memory utilization percentage on the device over the interval
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }
}