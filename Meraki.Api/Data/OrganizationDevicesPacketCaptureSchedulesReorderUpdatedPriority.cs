namespace Meraki.Api.Data;

/// <summary>
/// Updated Priority
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesReorderUpdatedPriority
{
	/// <summary>
	/// Priority value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "priority")]
	public int Priority { get; set; }

	/// <summary>
	/// Id of the scheduled packet capture
	/// </summary>
	[Obsolete("This property removed in API v1.59")]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pcapScheduleConfigurationId")]
	public string PcapScheduleConfigurationId { get; set; } = string.Empty;

	/// <summary>
	/// Id of the scheduled packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scheduleId")]
	public string ScheduleId { get; set; } = string.Empty;
}