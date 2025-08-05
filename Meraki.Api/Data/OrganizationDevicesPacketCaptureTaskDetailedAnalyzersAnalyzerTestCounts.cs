namespace Meraki.Api.Data;

/// <summary>
/// Count of various tests from the packet capture analysis result
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestCounts
{
	/// <summary>
	/// The number of failed tests run under this analyzer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failures")]
	public int Failures { get; set; }

	/// <summary>
	/// The number of successful tests run under this analyzer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "successes")]
	public int Successes { get; set; }

	/// <summary>
	/// The total number of tests run under this analyzer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}