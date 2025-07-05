namespace Meraki.Api.Data;

/// <summary>
/// Device Associated with to the schedule
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileScheduleDevice
{
	/// <summary>
	/// Device associated to the schedule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public OrganizationDevicesPacketCaptureFileScheduleDeviceInformation Device { get; set; } = new();
}
