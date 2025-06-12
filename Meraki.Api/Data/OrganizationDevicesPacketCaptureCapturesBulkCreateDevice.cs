namespace Meraki.Api.Data;

/// <summary>
/// One of the devices of the packet capture file
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesBulkCreateDevice
{
	/// <summary>
	/// interfaces to capture
	/// </summary>
	[DataMember(Name = "interface")]
	public string? Interface { get; set; }

	/// <summary>
	/// Serial of the devices to schedule packet capture
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// switchports to capture
	/// </summary>
	[DataMember(Name = "switchports")]
	public string? Switchports { get; set; }
}