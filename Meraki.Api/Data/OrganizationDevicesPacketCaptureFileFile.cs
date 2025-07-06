namespace Meraki.Api.Data;

/// <summary>
/// Object containing information about the file
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileFile
{
	/// <summary>
	/// File size of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "size")]
	public int Size { get; set; }
}