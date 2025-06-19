namespace Meraki.Api.Data;

/// <summary>
/// Information regarding memory usage on the device over the interval
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemIntervalMemoryFree
{
	/// <summary>
	/// Maximum memory in kB free on the device over the interval
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Median memory in kB free on the device over the interval rounded up to nearest integer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "median")]
	public int Median { get; set; }

	/// <summary>
	/// Minimum memory in kB free on the device over the interval
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}