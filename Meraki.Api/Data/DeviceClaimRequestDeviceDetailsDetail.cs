using Meraki.Api.Interfaces.General.Devices;

namespace Meraki.Api.Data;

/// <summary>
/// ClaimNetworkDevicesDeviceDetailsDetail
/// /// </summary>
[DataContract]
public class DeviceClaimRequestDeviceDetailsDetail
{
	/// <summary>
	/// Name of device detail
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Value of device detail
	/// </summary>
	[DataMember(Name = "value")]
	public string? Value { get; set; }
}
