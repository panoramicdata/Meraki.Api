namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Captures Response
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesResponse
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationDevicesPacketCaptureCapturesMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of packet capture files
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationDevicesPacketCaptureFile> Items { get; set; } = [];
}
