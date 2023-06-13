namespace Meraki.Api.Data;
/// <summary>
/// Availability history for a device
/// </summary>
[DataContract]

public class DeviceAvailabilityHistory
{
	/// <summary>
	/// Category of event: status, reboot, or upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp, in iso8601 format, at which the event happened
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public DateTime Ts { get; set; }

	/// <summary>
	/// Details about the status changes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "details")]
	public DeviceAvailabilityHistoryDetails Details { get; set; } = new();

	/// <summary>
	/// Device information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public DeviceAvailabilityHistoryDevice Device { get; set; } = new();

	/// <summary>
	/// Network information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public DeviceAvailabilityHistoryNetwork Network { get; set; } = new();
}