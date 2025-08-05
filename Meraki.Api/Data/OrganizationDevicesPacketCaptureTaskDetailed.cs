namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Task Detailed
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailed
{
	/// <summary>
	/// File name of the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fileName")]
	public string FileName { get; set; } = string.Empty;

	/// <summary>
	/// File path of the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filePathUrl")]
	public string FilePathUrl { get; set; } = string.Empty;

	/// <summary>
	/// Status of the packet analysis task
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Type of the packet analysis task
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "task")]
	public string Task { get; set; } = string.Empty;

	/// <summary>
	/// Result of the packet analysis task
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "result")]
	public object Result { get; set; } = new();

	/// <summary>
	/// Analysis results of the various analyzers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "analyzers")]
	public OrganizationDevicesPacketCaptureTaskDetailedAnalyzers Analyzers { get; set; } = new();

	/// <summary>
	/// Summary of the packet capture analysis result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "summary")]
	public OrganizationDevicesPacketCaptureTaskDetailedSummary Summary { get; set; } = new();
}
