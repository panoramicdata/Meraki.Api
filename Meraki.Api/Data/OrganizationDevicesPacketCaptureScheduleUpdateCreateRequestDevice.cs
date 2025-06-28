namespace Meraki.Api.Data;

/// <summary>
/// Device details
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureScheduleUpdateCreateRequestDevice
{
	/// <summary>
	/// Interface to capture
	/// </summary>
	[DataMember(Name = "interface")]
	public string? Interface { get; set; }

	/// <summary>
	/// Serial of the devices to schedule packet capture
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Switchports to capture
	/// </summary>
	[DataMember(Name = "switchports")]
	public string? Switchports { get; set; }
}