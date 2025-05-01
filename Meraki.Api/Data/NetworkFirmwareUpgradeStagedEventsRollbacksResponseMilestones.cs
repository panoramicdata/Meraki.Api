namespace Meraki.Api.Data;

/// <summary>
/// The Staged Upgrade Milestones for the stage
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksResponseMilestones
{
	/// <summary>
	/// Time that the group was canceled
	/// </summary>
	[DataMember(Name = "canceledAt")]
	public string? CanceledAt { get; set; }

	/// <summary>
	/// Finish time for the group
	/// </summary>
	[DataMember(Name = "completedAt")]
	public string? CompletedAt { get; set; }

	/// <summary>
	/// Scheduled start time for the group
	/// </summary>
	[DataMember(Name = "scheduledFor")]
	public string? ScheduledFor { get; set; }

	/// <summary>
	/// Start time for the group
	/// </summary>
	[DataMember(Name = "startedAt")]
	public string? StartedAt { get; set; }
}