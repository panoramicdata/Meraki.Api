namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrade Staged Events Defer Request
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsDeferResponse
{
	/// <summary>
	/// The network devices to be updated
	/// </summary>
	[DataMember(Name = "products")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworkFirmwareUpdateStagedEventsProducts? Products { get; set; }

	/// <summary>
	/// Reasons for the rollback
	/// </summary>
	[DataMember(Name = "reasons")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworkFirmwareUpgradeStagedEventsReason>? Reasons { get; set; }

	/// <summary>
	/// The ordered stages in the network
	/// </summary>
	[DataMember(Name = "stages")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworkFirmwareUpgradeStagedEventsStage>? Stages { get; set; }
}
