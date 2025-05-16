namespace Meraki.Api.Data;

/// <summary>
/// Schedule packet capture
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedule
{
	/// <summary>
	/// The number of pcaps captured/performed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "captureCount")]
	public int CaptureCount { get; set; }

	/// <summary>
	/// Duration of scheduled packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "duration")]
	public int Duration { get; set; }

	/// <summary>
	/// Priority of the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "priority")]
	public int Priority { get; set; }

	/// <summary>
	/// Time of creation of scheduled packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Filter expression for the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filterExpression")]
	public string FilterExpression { get; set; } = string.Empty;

	/// <summary>
	/// Pcap log id of the latest pcap from this schedule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastCaptureId")]
	public string LastCaptureId { get; set; } = string.Empty;

	/// <summary>
	/// Name of scheduled packet capture
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Reason of scheduled packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "notes")]
	public string Notes { get; set; } = string.Empty;

	/// <summary>
	/// Id of scheduled packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scheduleId")]
	public string ScheduleId { get; set; } = string.Empty;

	/// <summary>
	/// Time of updation of scheduled packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public string UpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Whether the packet capture schedule is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Any warnings pertaining to the schedule and it's nodes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warnings")]
	public List<string> Warnings { get; set; } = [];

	/// <summary>
	/// Admin who created the scheduled packet capture
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "admin")]
	public OrganizationDevicesPacketCaptureFileAdmin Admin { get; set; } = new();

	/// <summary>
	/// Schedule of the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "schedule")]
	public OrganizationDevicesPacketCaptureFileSchedule Schedule { get; set; } = new();

	/// <summary>
	/// Devices associated to the schedule
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "devices")]
	public List<OrganizationDevicesPacketCaptureFileScheduleDevice> Devices { get; set; } = [];
}
