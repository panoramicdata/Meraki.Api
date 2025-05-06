namespace Meraki.Api.Data;

/// <summary>
/// Contains firmware upgrade version information
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsCreateRequestStage
{
	/// <summary>
	/// The Staged Upgrade Group containing the name and ID
	/// </summary>
	[DataMember(Name = "group")]
	[ApiAccess(ApiAccess.Create)]
	public NetworkFirmwareUpgradeStagedEventsCreateRequestStageGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the specific stage
	/// </summary>
	[DataMember(Name = "milestones")]
	[ApiAccess(ApiAccess.Create)]
	public NetworkFirmwareUpgradeStagedEventsCreateRequestStageMilestones? Milestones { get; set; }
}
