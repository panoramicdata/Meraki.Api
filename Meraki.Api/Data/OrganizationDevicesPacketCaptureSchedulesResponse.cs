namespace Meraki.Api.Data;

/// <summary>
/// Organization devices packet capture schedules response
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesResponse
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationDevicesPacketCaptureSchedulesMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of scheduled packet captures
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationDevicesPacketCaptureSchedule> Items { get; set; } = [];
}
