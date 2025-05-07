namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrade Staged Events Rollbacks Response
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksResponse
{
	/// <summary>
	/// The network devices to be updated
	/// </summary>
	[DataMember(Name = "products")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworkFirmwareUpdateStagedEventsProducts? Products { get; set; }

	/// <summary>
	/// Reasosn for the callback
	/// </summary>
	[DataMember(Name = "reasons")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworkFirmwareUpgradeStagedEventsReason>? Reasons { get; set; }

	/// <summary>
	/// The ordered stages in the network
	/// </summary>
	[DataMember(Name = "stages")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworkFirmwareUpgradeStagedEventsRollbacksResponseStage>? Stages { get; set; }
}
