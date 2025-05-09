namespace Meraki.Api.Data;

/// <summary>
/// Staged Upgrade Group
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedStageUpdateStagedJsonItem
{
	/// <summary>
	/// The Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "group")]
	public NetworkFirmwareUpgradesStagedStageUpdateStagedGroup? Group { get; set; }
}
