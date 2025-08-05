namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Task
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTask
{
	/// <summary>
	/// 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "task")]
	public string Task { get; set; } = string.Empty;

	/// <summary>
	/// 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "taskId")]
	public string TaskId { get; set; } = string.Empty;
}
