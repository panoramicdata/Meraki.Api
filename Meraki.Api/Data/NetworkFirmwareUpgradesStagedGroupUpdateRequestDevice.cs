namespace Meraki.Api.Data;

/// <summary>
/// Data Array of Devices containing the name and serial
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupUpdateRequestDevice
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
	public string? Serial { get; set; }
}