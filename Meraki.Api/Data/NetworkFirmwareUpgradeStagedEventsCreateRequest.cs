namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrade Staged Events Create Request
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsCreateRequest
{
	/// <summary>
	/// Version information for the switch network being upgraded
	/// </summary>
	[DataMember(Name = "switch")]
	public NetworkFirmwareUpgradeStagedEventsCreateRequestSwitch? Switch { get; set; }

	/// <summary>
	/// Version information for the switch network being upgraded
	/// </summary>
	[DataMember(Name = "switchCatalyst")]
	public NetworkFirmwareUpgradeStagedEventsCreateRequestSwitch? SwitchCatalyst { get; set; }

	/// <summary>
	/// Contains firmware upgrade version information
	/// </summary>
	[DataMember(Name = "stages")]
	public List<NetworkFirmwareUpgradeStagedEventsCreateRequestStage>? Stages { get; set; }
}
