namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Availabilities Change History Item
/// </summary>
[DataContract]
[DebuggerDisplay("{Category}: {Device.Name} ({Device.Model} {Device.Serial}) - {Network.Name} ({Network.Id})")]
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

	/// <summary>
	/// Category information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;
}
