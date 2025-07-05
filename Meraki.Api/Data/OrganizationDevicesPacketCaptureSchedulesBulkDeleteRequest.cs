namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Schedules Bulk Delete Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesBulkDeleteRequest
{
	/// <summary>
	/// Delete the packet capture schedules of the specified schedule ids
	/// </summary>
	[DataMember(Name = "scheduleIds")]
	public List<string> ScheduleIds { get; set; } = [];
}
