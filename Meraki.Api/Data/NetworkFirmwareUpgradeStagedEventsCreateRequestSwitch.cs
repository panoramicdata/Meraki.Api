namespace Meraki.Api.Data;

/// <summary>
/// Version information for the switch network being upgraded
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsCreateRequestSwitch
{
	/// <summary>
	/// The next upgrade version for the switch network
	/// </summary>
	[DataMember(Name = "nextUpgrade")]
	public NetworkFirmwareUpgradeStagedEventsCreateRequestNextUpgrade? NextUpgrade { get; set; }
}
