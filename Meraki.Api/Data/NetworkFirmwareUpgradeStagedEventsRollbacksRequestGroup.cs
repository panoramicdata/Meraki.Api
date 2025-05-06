namespace Meraki.Api.Data;

/// <summary>
/// The Staged Upgrade Group containing the name and ID
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksRequestGroup
{
	/// <summary>
	/// ID of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.Create)]
	public string Id { get; set; } = string.Empty;
}