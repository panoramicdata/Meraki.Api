namespace Meraki.Api.Data;

/// <summary>
/// A test ran under this analyzer
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestResult
{
	/// <summary>
	/// All failed tests ran under this analyzer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failed")]
	public List<OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestResultFail> Failed { get; set; } = [];

	/// <summary>
	/// All passed tests ran under this analyzer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "passed")]
	public List<OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestResultPass> Passed { get; set; } = [];
}
