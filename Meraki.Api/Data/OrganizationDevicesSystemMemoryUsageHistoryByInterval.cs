namespace Meraki.Api.Data;

/// <summary>
/// Organizaiton Devices System Memory Usage History By Interval
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByInterval
{
	/// <summary>
	/// Other metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalMetadata Meta { get; set; } = new();

	/// <summary>
	/// The top-level property containing all memory utilization data.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationDevicesSystemMemoryUsageHistoryByIntervalItem> Items { get; set; } = [];
}
