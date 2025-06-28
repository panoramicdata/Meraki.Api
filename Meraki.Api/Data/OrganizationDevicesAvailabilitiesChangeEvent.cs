namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Availabilities Change History Item
/// </summary>
[DataContract]
public class OrganizationDevicesAvailabilitiesChangeEvent
{
	/// <summary>
	/// Timestamp, in iso8601 format, at which the event happened
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Details about the status changes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "details")]
	public OrganizationDevicesAvailabilitiesChangeEventDetails Details { get; set; } = new();

	/// <summary>
	/// Device information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public OrganizationDevicesAvailabilitiesChangeEventDevice Device { get; set; } = new();

	/// <summary>
	/// Network information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationDevicesAvailabilitiesChangeEventNetwork Network { get; set; } = new();
}
