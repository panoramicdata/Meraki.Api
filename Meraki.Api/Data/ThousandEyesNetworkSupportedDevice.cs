namespace Meraki.Api.Data;

/// <summary>
/// Network primary MX device
/// </summary>
[DataContract]
public class ThousandEyesNetworkSupportedDevice
{
	/// <summary>
	/// Model of the network primary MX device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// ThousandEyes agent
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "agent")]
	public ThousandEyesNetworkSupportedDeviceAgent Agent { get; set; } = new();

	/// <summary>
	/// Network primary MX device firmware
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "firmware")]
	public ThousandEyesNetworkSupportedDeviceFirmware Firmware { get; set; } = new();
}
