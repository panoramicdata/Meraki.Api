namespace Meraki.Api.Data;

/// <summary>
/// THe Staged Upgrade Milestones for the specific stage
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksRequestMilestones
{
	/// <summary>
	/// The start time of the staged upgrade stage. (In ISO-8601 format, in the time zone of the network.)
	/// </summary>
	[DataMember(Name = "scheduledFor")]
	public string ScheduledFor { get; set; } = string.Empty;
}