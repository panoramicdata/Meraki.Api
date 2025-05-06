namespace Meraki.Api.Data;

/// <summary>
/// Acompleted or in-progress stage in the network with their new start times.
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksRequestStage
{
	/// <summary>
	/// The Staged Upgrade Group containing the name and ID
	/// </summary>
	[DataMember(Name = "group")]
	[ApiAccess(ApiAccess.Create)]
	public NetworkFirmwareUpgradeStagedEventsRollbacksRequestGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the specific stage
	/// </summary>
	[DataMember(Name = "milestones")]
	[ApiAccess(ApiAccess.Create)]
	public NetworkFirmwareUpgradeStagedEventsRollbacksRequestMilestones? Milestones { get; set; }
}
