namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrade Staged Events
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsResponse
{
	/// <summary>
	/// The network devices to be update
	/// </summary>
	[DataMember(Name = "products")]
	public List<NetworkFirmwareUpgradeStagedEventsProduct>? Products { get; set; }

	/// <summary>
	/// Reasons for the rollback
	/// </summary>
	[DataMember(Name = "reasons")]
	public List<NetworkFirmwareUpgradeStagedEventsReason>? Reasons { get; set; }

	/// <summary>
	/// The ordered stages in the network
	/// </summary>
	[DataMember(Name = "stages")]
	public List<NetworkFirmwareUpgradeStagedEventsStage>? Stages { get; set; }
}
