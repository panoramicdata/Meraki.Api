namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Schedules Reorder Response
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesReorderResponse
{
	/// <summary>
	/// List of updated priorities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedPriorities")]
	public List<OrganizationDevicesPacketCaptureSchedulesReorderUpdatedPriority> UpdatedPriorities { get; set; } = [];
}
