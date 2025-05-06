namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrades Staged Stage Update Request
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedStageUpdateRequest
{
	/// <summary>
	/// The Staged 
	/// </summary>
	[DataMember(Name = "_json")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworkFirmwareUpgradesStagedStageUpdateStagedJsonItem>? Json { get; set; }
}
