namespace Meraki.Api.Data;

/// <summary>
/// Schedule id and priority
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesReorderOrderItem
{
	/// <summary>
	/// The priority of the schedule
	/// </summary>
	[DataMember(Name = "priority")]
	public int? Priority { get; set; }

	/// <summary>
	/// ID of the schedule to update to the specified priority
	/// </summary>
	[DataMember(Name = "scheduleId")]
	public string? ScheduleId { get; set; }
}