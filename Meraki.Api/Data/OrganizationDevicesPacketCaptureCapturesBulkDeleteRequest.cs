namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Captures Bulk Delete Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesBulkDeleteRequest
{
	/// <summary>
	/// Delete the packet captures of the specified capture ids
	/// </summary>
	[DataMember(Name = "captureIds")]
	public List<string> CaptureIds { get; set; } = [];
}
