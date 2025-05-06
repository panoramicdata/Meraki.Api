namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrade Staged Events Rollbacks Request
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksRequest
{
	/// <summary>
	/// The reason for rolling back the staged upgrade
	/// </summary>
	[DataMember(Name = "reasons")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworkFirmwareUpgradeStagedEventsRollbacksRequestReason>? Reasons { get; set; }

	/// <summary>
	/// All completed or in-progress stages in the network with their new start times. All pending stages will be canceled
	/// </summary>
	[DataMember(Name = "stages")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworkFirmwareUpgradeStagedEventsRollbacksRequestStage>? Stages { get; set; }
}
