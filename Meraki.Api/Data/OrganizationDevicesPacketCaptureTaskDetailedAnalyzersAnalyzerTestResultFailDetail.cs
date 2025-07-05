namespace Meraki.Api.Data;

/// <summary>
/// Detail of a failed test ran under this analyzer
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestResultFailDetail
{
	/// <summary>
	/// Count of packets where test failed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failureCount")]
	public int FailureCount { get; set; }

	/// <summary>
	/// Details about test
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "detailMessage")]
	public string DetailMessage { get; set; } = string.Empty;

	/// <summary>
	/// Test subcategory
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subCategory")]
	public string SubCategory { get; set; } = string.Empty;

	/// <summary>
	/// Device names of devices present within the test failure
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public List<string> Devices { get; set; } = [];

	/// <summary>
	/// IP addresses of devices present within the test failure
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ips")]
	public List<string> Ips { get; set; } = [];

	/// <summary>
	/// MAC addresses of devices present within the test failure
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "macs")]
	public List<string> Macs { get; set; } = [];

	/// <summary>
	/// Packets present within the failed test
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "packets")]
	public List<int> Packets { get; set; } = [];
}