namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Schedule Delete Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureScheduleDeleteRequest
{
	/// <summary>
	/// Delete the capture schedules of the specified capture schedule id
	/// </summary>
	[DataMember(Name = "scheduleId")]
	public string ScheduleId { get; set; } = string.Empty;
}
