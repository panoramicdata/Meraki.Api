namespace Meraki.Api.Data;

/// <summary>
/// The reason for rolling back the staged upgrade
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksRequestReason
{
	/// <summary>
	/// Reason for the rollback
	/// </summary>
	[DataMember(Name = "category")]
	[ApiAccess(ApiAccess.Create)]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// Additional comment about the rollback
	/// </summary>
	[DataMember(Name = "comment")]
	[ApiAccess(ApiAccess.Create)]
	public string Comment { get; set; } = string.Empty;
}