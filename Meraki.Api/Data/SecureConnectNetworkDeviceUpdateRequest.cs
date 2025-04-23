namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectNetworkDeviceUpdateRequest
/// </summary>
[DataContract]
public class SecureConnectNetworkDeviceUpdateRequest
{
	/// <summary>
	/// The name of the device.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
