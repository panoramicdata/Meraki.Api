namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Schedules Reorder Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesReorderRequest
{
	/// <summary>
	/// Array of schedule IDs and their priorities to reorder.
	/// </summary>
	[DataMember(Name = "order")]
	public List<OrganizationDevicesPacketCaptureSchedulesReorderOrderItem> Order { get; set; } = [];
}
