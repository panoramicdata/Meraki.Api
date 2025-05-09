namespace Meraki.Api.Data;

/// <summary>
/// Device containing the name and serial
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupCreateRequestAssignedDevice
{
	/// <summary>
	/// Name of the device
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Serial of the device
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}