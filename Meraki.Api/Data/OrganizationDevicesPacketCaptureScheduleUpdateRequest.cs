namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Schedule Update Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureScheduleUpdateRequest
{
	/// <summary>
	/// Duration of the capture in seconds
	/// </summary>
	[DataMember(Name = "duration")]
	public int? Duration { get; set; }

	/// <summary>
	/// Filter expression for the capture
	/// </summary>
	[DataMember(Name = "filterExpression")]
	public string? FilterExpression { get; set; }

	/// <summary>
	/// Name of the packet capture file
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Reason for capture
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// Enable or disable the schedule
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Schedule details
	/// </summary>
	[DataMember(Name = "schedule")]
	public OrganizationDevicesPacketCaptureScheduleCreateUpdateRequestSchedule? Schedule { get; set; }

	/// <summary>
	/// Device details
	/// </summary>
	[DataMember(Name = "devices")]
	public List<OrganizationDevicesPacketCaptureScheduleUpdateCreateRequestDevice> Devices { get; set; } = [];
}
