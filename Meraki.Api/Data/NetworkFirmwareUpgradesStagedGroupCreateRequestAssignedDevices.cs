namespace Meraki.Api.Data;

/// <summary>
/// The devices and Switch Stacks assigned to the Group
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupCreateRequestAssignedDevices
{
	/// <summary>
	/// Data Array of Devices containing the name and serial
	/// </summary>
	[DataMember(Name = "devices")]
	public List<NetworkFirmwareUpgradesStagedGroupCreateRequestAssignedDevice>? Devices { get; set; }

	/// <summary>
	/// Data Array of Switch Stacks containing the name and id
	/// </summary>
	[DataMember(Name = "switchStacks")]
	public List<NetworkFirmwareUpgradesStagedGroupCreateRequestAssignedSwitchStack>? SwitchStacks { get; set; }
}
