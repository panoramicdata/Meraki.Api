namespace Meraki.Api.Data;

/// <summary>
/// The Staged Upgrade Milestones for the stage
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsStageMilestones
{
	/// <summary>
	/// Time that th group was canceled
	/// </summary>
	[DataMember(Name = "canceledAt")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? CanceledAt { get; set; }

	/// <summary>
	/// Finish time for the group
	/// </summary>
	[DataMember(Name = "completedAt")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? CompletedAt { get; set; }

	/// <summary>
	/// Scheduled start time for the group
	/// </summary>
	[DataMember(Name = "scheduledFor")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? ScheduledFor { get; set; }

	/// <summary>
	/// Start time for the group
	/// </summary>
	[DataMember(Name = "startedAt")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? StartedAt { get; set; }
}
