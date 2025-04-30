namespace Meraki.Api.Interfaces.General.Networks;

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
	public NetworkFirmwareUpgradeStagedEventsUpdateRequestGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the specific stage
	/// </summary>
	[DataMember(Name = "milestones")]
	public NetworkFirmwareUpgradeStagedEventsUpdateRequestMilestones? Milestones { get; set; }
}
