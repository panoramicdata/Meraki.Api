namespace Meraki.Api.Data;

/// <summary>
/// The next upgrade version for the switch network
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsCreateRequestNextUpgrade
{
	/// <summary>
	/// The version to be updated to for switch devices
	/// </summary>
	[DataMember(Name = "toVersion")]
	public NetworkFirmwareUpgradeStagedEventsCreateRequestNextUpgradeToVersion? ToVersion { get; set; }
}
