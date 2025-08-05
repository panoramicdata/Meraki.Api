namespace Meraki.Api.Data;

/// <summary>
/// Analysis results of the various analyzers
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedAnalyzers
{
	/// <summary>
	/// Analyzer analysis results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "analyzer")]
	public OrganizationDevicesPacketCaptureTaskDetailedAnalyzersAnalyzer Analyzer { get; set; } = new();
}
