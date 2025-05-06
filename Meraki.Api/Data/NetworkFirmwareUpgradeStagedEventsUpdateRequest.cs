namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrade Staged Events Update Request
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsUpdateRequest
{
	/// <summary>
	/// The Staged Upgrade Group containing the name and ID
	/// </summary>
	[DataMember(Name = "group")]
	[ApiAccess(ApiAccess.Update)]
	public NetworkFirmwareUpgradeStagedEventsUpdateRequestGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the specific stage
	/// </summary>
	[DataMember(Name = "milestones")]
	[ApiAccess(ApiAccess.Update)]
	public NetworkFirmwareUpgradeStagedEventsUpdateRequestMilestones? Milestones { get; set; }
}
