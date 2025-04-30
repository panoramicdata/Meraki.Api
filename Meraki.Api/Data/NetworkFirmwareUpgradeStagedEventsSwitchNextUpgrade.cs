namespace Meraki.Api.Data;

/// <summary>
/// Details of the next firmware upgrade
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsSwitchNextUpgrade
{
	/// <summary>
	/// 
	/// </summary>
	[DataMember(Name = "toVersion")]
	public NetworkFirmwareUpgradeStagedEventsSwitchNextUpgradeToVersion? ToVersion { get; set; }
}
