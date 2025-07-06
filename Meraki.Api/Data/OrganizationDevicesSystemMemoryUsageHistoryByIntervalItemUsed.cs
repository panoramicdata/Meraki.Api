namespace Meraki.Api.Data;

/// <summary>
/// Information regarding memory usage on the device over the entire timespan
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemUsed
{
	/// <summary>
	/// Median memory in kB used on the device over the entire timespan rounded up to nearest integer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "median")]
	public int Median { get; set; }
}