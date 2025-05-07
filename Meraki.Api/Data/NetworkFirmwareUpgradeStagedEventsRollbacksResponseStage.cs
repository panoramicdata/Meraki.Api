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
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Status { get; set; }

	/// <summary>
	/// The staged upgrade Group
	/// </summary>
	[DataMember(Name = "group")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworkFirmwareUpgradeStagedEventsRollbacksResponseGroup? Group { get; set; }

	/// <summary>
	/// The Staged Upgrade Milestones for the stage
	/// </summary>
	[DataMember(Name = "milestones")]
	[ApiAccess(ApiAccess.Read)]
	public NetworkFirmwareUpgradeStagedEventsRollbacksResponseMilestones? Milestones { get; set; }
}
