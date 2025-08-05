namespace Meraki.Api.Data;

/// <summary>
/// Count of various analyzers run on the packet capture
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedSummaryCounts
{
	/// <summary>
	/// The number of analyzers that returned failed results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failures")]
	public int Failures { get; set; }

	/// <summary>
	/// The number of analyzers that returned successful results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "successes")]
	public int Successes { get; set; }

	/// <summary>
	/// The total number of analyzers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}