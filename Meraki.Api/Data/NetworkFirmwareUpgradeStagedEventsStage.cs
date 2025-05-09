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
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Status { get; set; }

	/// <summary>
	/// The stages upgrade group
	/// </summary>
	[DataMember(Name = "group")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworkFirmwareUpgradeStagedEventsStageGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the stage
	/// </summary>
	[DataMember(Name = "milestones")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworkFirmwareUpgradeStagedEventsStageMilestones? Milestones { get; set; }
}