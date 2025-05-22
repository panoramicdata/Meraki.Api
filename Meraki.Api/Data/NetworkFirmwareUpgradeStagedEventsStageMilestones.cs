﻿namespace Meraki.Api.Data;

/// <summary>
/// The Staged Upgrade Milestones for the stage
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsStageMilestones
{
	/// <summary>
	/// Time that the group was canceled
	/// </summary>
	[DataMember(Name = "canceledAt")]
	[ApiAccess(ApiAccess.Read)]
	public string? CanceledAt { get; set; }

	/// <summary>
	/// Finish time for the group
	/// </summary>
	[DataMember(Name = "completedAt")]
	[ApiAccess(ApiAccess.Read)]
	public string? CompletedAt { get; set; }

	/// <summary>
	/// Scheduled start time for the group
	/// </summary>
	[DataMember(Name = "scheduledFor")]
	[ApiAccess(ApiAccess.Read)]
	public string? ScheduledFor { get; set; }

	/// <summary>
	/// Start time for the group
	/// </summary>
	[DataMember(Name = "startedAt")]
	[ApiAccess(ApiAccess.Read)]
	public string? StartedAt { get; set; }
}
