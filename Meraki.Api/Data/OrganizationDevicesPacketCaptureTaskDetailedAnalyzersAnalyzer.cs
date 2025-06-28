namespace Meraki.Api.Data;

/// <summary>
/// Analyzer analysis results
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzer
{
	/// <summary>
	/// Whether the analyzer's protocols were present within the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "present")]
	public bool Present { get; set; }

	/// <summary>
	/// Device names of devices present within the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public List<string> Devices { get; set; } = [];

	/// <summary>
	/// IP addresses of devices present within the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ips")]
	public List<string> Ips { get; set; } = [];

	/// <summary>
	/// MAC addresses of devices present within the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "macs")]
	public List<string> Macs { get; set; } = [];

	/// <summary>
	/// Count of various tests from the packet capture analysis result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "testCounts")]
	public OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestCounts TestCounts { get; set; } = new();

	/// <summary>
	/// All tests ran under this analyzer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "testResults")]
	public List<OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestResult> TestResults { get; set; } = [];
}
