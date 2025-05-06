namespace Meraki.Api.Data;

/// <summary>
/// The device and Switch Stacks assigned to the Group
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupAssignedDevice
{
	/// <summary>
	/// Name of the device
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? Name { get; set; }

	/// <summary>
	/// Serial number of the device
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? Serial { get; set; }
}