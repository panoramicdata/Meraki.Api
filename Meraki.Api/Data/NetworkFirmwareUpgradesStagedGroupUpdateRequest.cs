namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrades Staged Group Update Request
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupUpdateRequest
{
	/// <summary>
	/// Description of the Staged Upgrade Group. Length must be 1 to 255 characters
	/// </summary>
	[DataMember(Name = "description")]
	[ApiAccess(ApiAccess.Update)]
	public string? Description { get; set; }

	/// <summary>
	/// Name of the Staged Upgrade Group. Length must be 1 to 255 characters
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Update)]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Boolean indicating the default Group. Any device that does not have a group explicitly assigned will upgrade with this group
	/// </summary>
	[DataMember(Name = "isDefault")]
	[ApiAccess(ApiAccess.Update)]
	public bool IsDefault { get; set; }

	/// <summary>
	/// The devices and Switch Stacks assigned to the Group
	/// </summary>
	[DataMember(Name = "assignedDevices")]
	[ApiAccess(ApiAccess.Update)]
	public NetworkFirmwareUpgradesStagedGroupUpdateRequestAssignedDevices? AssignedDevices { get; set; }
}
