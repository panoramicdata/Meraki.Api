namespace Meraki.Api.Data;

/// <summary>
/// A failed test ran under this analyzer
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestResultFail
{
	/// <summary>
	/// The name of the failed test
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Status of the failed test
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public bool Status { get; set; }

	/// <summary>
	/// Details of failed tests ran under this analyzer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "details")]
	public List<OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestResultFailDetail> Details { get; set; } = [];
}
