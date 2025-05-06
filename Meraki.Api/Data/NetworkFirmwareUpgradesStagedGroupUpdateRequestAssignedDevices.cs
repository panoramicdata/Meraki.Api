namespace Meraki.Api.Data;

/// <summary>
/// The devices and Switch Stacks assigned to the Group
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupUpdateRequestAssignedDevices
{
	/// <summary>
	/// Data Array of Devices containing the name and serial
	/// </summary>
	[DataMember(Name = "devices")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworkFirmwareUpgradesStagedGroupUpdateRequestDevice>? Devices { get; set; }

	/// <summary>
	/// Data Array of Switch Stacks containing the name and id
	/// </summary>
	[DataMember(Name = "switchStacks")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworkFirmwareUpgradesStagedGroupUpdateRequestSwitchStack>? SwitchStacks { get; set; }
}
