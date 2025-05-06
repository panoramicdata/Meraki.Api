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
	[ApiAccess(ApiAccess.Update)]
	public string? Description { get; set; }

	/// <summary>
	/// Id of staged upgrade group
	/// </summary>
	[DataMember(Name = "groupId")]
	[ApiAccess(ApiAccess.Update)]
	public string? GroupId { get; set; }

	/// <summary>
	/// Name of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Update)]
	public string? Name { get; set; }

	/// <summary>
	/// Boolean indicating the default Group. Any device that does not have a group explicitly assigned will upgrade with this group
	/// </summary>
	[DataMember(Name = "isDefault")]
	[ApiAccess(ApiAccess.Update)]
	public bool? isDefault { get; set; }

	/// <summary>
	/// The devices and Switch Stacks assigned to the Group
	/// </summary>
	[DataMember(Name = "assignedDevices")]
	[ApiAccess(ApiAccess.Update)]
	public NetworkFirmwareUpgradesStagedGroupAssignedDevices? AssignedDevices { get; set; }
}
