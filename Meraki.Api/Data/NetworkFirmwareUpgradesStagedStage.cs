namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrades Staged Stage
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedStage
{
	/// <summary>
	/// The Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "group")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public NetworkFirmwareUpgradesStagedStageGroup? Group { get; set; }
}
