namespace Meraki.Api.Data;

/// <summary>
/// Summary of the packet capture analysis result
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedSummary
{
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
	/// Count of various analyzers run on the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationDevicesPacketCaptureTaskDetailedSummaryCounts Counts { get; set; } = new();

	/// <summary>
	/// Devices from the packet capture analysis result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public List<OrganizationDevicesPacketCaptureTaskDetailedSummaryDevice> Devices { get; set; } = [];
}
