namespace Meraki.Api.Data;

/// <summary>
/// Information regarding memory availability on the device over the entire timespan
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemFree
{
	/// <summary>
	/// Median memory in kB free on the device over the entire timespan rounded up to nearest integer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "median")]
	public int Median { get; set; }
}