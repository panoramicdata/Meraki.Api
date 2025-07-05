namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Captures Bulk Create Response
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesBulkCreateResponse
{
	/// <summary>
	/// List of packet capture files
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationDevicesPacketCaptureFile> Items { get; set; } = [];
}
