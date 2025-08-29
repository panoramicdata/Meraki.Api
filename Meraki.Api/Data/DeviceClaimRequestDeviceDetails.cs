using Meraki.Api.Interfaces.General.Devices;

namespace Meraki.Api.Data;

/// <summary>
/// ClaimNetworkDevicesDeviceDetails
/// </summary>
[DataContract]
public class DeviceClaimRequestDeviceDetails
{
	/// <summary>
	/// The serial of the device these details relate to
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// An array of details. Supported list
	/// of details includes: "device mode", "username", "password", "enable password", "ap mapping type" and
	/// "ap network id". For onboarding into hybrid mode, the value of the device mode detail must be "monitored"
	/// </summary>
	[DataMember(Name = "details")]
	public List<DeviceClaimRequestDeviceDetailsDetail>? Details { get; set; }
}
