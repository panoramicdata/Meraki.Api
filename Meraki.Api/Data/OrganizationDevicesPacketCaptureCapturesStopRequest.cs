namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Captures Stop Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesStopRequest
{
	/// <summary>
	/// The serial(s) of the device(s) to stop the capture on
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];
}
