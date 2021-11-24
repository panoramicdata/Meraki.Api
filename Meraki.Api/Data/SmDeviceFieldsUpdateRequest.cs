namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSmDeviceFields
/// </summary>
[DataContract]
public class SmDeviceFieldsUpdateRequest
{
	/// <summary>
	/// The wifiMac of the device to be modified.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "wifiMac")]
	public string WifiMac { get; set; } = string.Empty;

	/// <summary>
	/// The id of the device to be modified.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The serial of the device to be modified.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets DeviceFields
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "deviceFields")]
	public DeviceFields DeviceFields { get; set; } = new();
}
