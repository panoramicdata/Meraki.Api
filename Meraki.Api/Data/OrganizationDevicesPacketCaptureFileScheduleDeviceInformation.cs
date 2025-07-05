namespace Meraki.Api.Data;

/// <summary>
/// Device associated to the schedule
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileScheduleDeviceInformation
{
	/// <summary>
	/// The interfaces on which to take the packet capture (applicable for Catalyst devices)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// The serial of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// The switchports on which to take the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "switchports")]
	public string Switchports { get; set; } = string.Empty;
}