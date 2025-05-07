namespace Meraki.Api.Data;

/// <summary>
/// Details of the next firmware upgrade
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsSwitchNextUpgrade
{
	/// <summary>
	/// Details of the version the device will upgrade to
	/// </summary>
	[DataMember(Name = "toVersion")]
	[ApiAccess(ApiAccess.Read)]
	public NetworkFirmwareUpgradeStagedEventsSwitchNextUpgradeToVersion? ToVersion { get; set; }
}
