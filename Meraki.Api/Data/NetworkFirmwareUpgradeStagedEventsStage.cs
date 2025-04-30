namespace Meraki.Api.Data;

/// <summary>
/// An order stage in the network
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsStage
{
	/// <summary>
	/// Current upgrade status of the group
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// The stages upgrade group
	/// </summary>
	[DataMember(Name = "group")]
	public NetworkFirmwareUpgradeStagedEventsStageGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the stage
	/// </summary>
	[DataMember(Name = "milestones")]
	public NetworkFirmwareUpgradeStagedEventsStageMilestones? Milestones { get; set; }
}