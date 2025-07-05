namespace Meraki.Api.Data;

/// <summary>
/// A successful test ran under this analyzer
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzerTestResultPass
{
	/// <summary>
	/// The name of the passed test
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Status of the passed test
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public bool Status { get; set; }

	/// <summary>
	/// Details of passed tests ran under this analyzer (empty list)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "details")]
	public List<string> Details { get; set; } = [];
}