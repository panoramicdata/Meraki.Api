namespace Meraki.Api.Data;

/// <summary>
/// An ordered stage in the network
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksResponseStage
{
	/// <summary>
	/// Current upgrade status of the group
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// The staged upgrade Group
	/// </summary>
	[DataMember(Name = "group")]
	public NetworkFirmwareUpgradeStagedEventsRollbacksResponseGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the stage
	/// </summary>
	[DataMember(Name = "milestones")]
	public NetworkFirmwareUpgradeStagedEventsRollbacksResponseMilestones? Milestones { get; set; }
}
