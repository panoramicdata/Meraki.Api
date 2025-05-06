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
	[ApiAccess(ApiAccess.Update)]
	public string? Name { get; set; }

	/// <summary>
	/// Serial of the device
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.Update)]
	public string? Serial { get; set; }
}