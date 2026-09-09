namespace Meraki.Api.Data;

/// <summary>
/// A device whose tags were modified by a bulk Systems Manager tag change
/// </summary>
[DataContract]
public class SmDevicesModifyTagsResponse
{
	/// <summary>
	/// The Meraki Id of the device record.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The device serial.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// The MAC of the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wifiMac")]
	public string? WifiMac { get; set; }

	/// <summary>
	/// An array of tags associated with the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}
