namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectNetworkDeviceCreateRequest
/// </summary>
[DataContract]
public class SecureConnectNetworkDeviceCreateRequest
{
	/// <summary>
	/// The MAC address of the device. The unique MAC address may include up to 12 characters and must not contain hyphens or colons.
	/// </summary>
	[DataMember(Name = "macAddress")]
	public string MacAddress { get; set; } = string.Empty;

	/// <summary>
	/// The model name of the device. Must be unique to your organization.
	/// </summary>
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// The name of the device.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The serial number of the device.
	/// </summary>
	[DataMember(Name = "serialNumber")]
	public string SerialNumber { get; set; } = string.Empty;
}
