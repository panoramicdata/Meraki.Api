namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// The Staged Upgrade Milestones for the specific stage
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsUpdateRequestMilestones
{
	/// <summary>
	/// The start time of the staged upgrade stage. (In ISO-8601 format, in the time zone of the network.)
	/// </summary>
	[DataMember(Name = "scheduledFor")]
	public string ScheduledFor { get; set; } = string.Empty;
}
