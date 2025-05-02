namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrades Staged Group Update Response
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupUpdateResponse
{
	/// <summary>
	/// Description of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Id of staged upgrade group
	/// </summary>
	[DataMember(Name = "groupId")]
	public string? GroupId { get; set; }

	/// <summary>
	/// Name of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Boolean indicating the default Group. Any device that does not have a group explicitly assigned will upgrade with this group
	/// </summary>
	[DataMember(Name = "isDefault")]
	public bool? isDefault { get; set; }

	/// <summary>
	/// The devices and Switch Stacks assigned to the Group
	/// </summary>
	[DataMember(Name = "assignedDevices")]
	public NetworkFirmwareUpgradesStagedGroupAssignedDevices? AssignedDevices { get; set; }
}
