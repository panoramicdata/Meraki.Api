namespace Meraki.Api.Data;

/// <summary>
/// WipeNetworkSmDevice
/// </summary>
[DataContract]
public class WipeNetworkSmDeviceRequest
{
	/// <summary>
	/// The wifiMac of the device to be wiped.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "wifiMac")]
	public string? WifiMac { get; set; }

	/// <summary>
	/// The id of the device to be wiped.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The serial of the device to be wiped.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// The pin number (a six digit value) for wiping a macOS device. Required only for macOS devices.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "pin")]
	public int? Pin { get; set; }
}
