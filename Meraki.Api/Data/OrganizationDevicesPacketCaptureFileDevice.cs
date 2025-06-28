namespace Meraki.Api.Data;

/// <summary>
/// One of the device(s) of the packet capture file
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileDevice
{
	/// <summary>
	/// Name of device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The serial of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}