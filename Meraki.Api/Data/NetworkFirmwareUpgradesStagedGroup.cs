namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrades Staged Group
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroup
{
	/// <summary>
	/// Description of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "description")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Description { get; set; }

	/// <summary>
	/// Id of staged upgrade group
	/// </summary>
	[DataMember(Name = "groupId")]
	[ApiAccess(ApiAccess.Read)]
	public string? GroupId { get; set; }

	/// <summary>
	/// Name of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Name { get; set; }

	/// <summary>
	/// Boolean indicating the default Group. Any device that does not have a group explicitly assigned will upgrade with this group
	/// </summary>
	[DataMember(Name = "isDefault")]
	[ApiAccess(ApiAccess.Read)]
	public bool? IsDefault { get; set; }

	/// <summary>
	/// The devices and Switch Stacks assigned to the Group
	/// </summary>
	[DataMember(Name = "assignedDevices")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworkFirmwareUpgradesStagedGroupAssignedDevices? AssignedDevices { get; set; }
}
