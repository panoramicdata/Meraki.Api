namespace Meraki.Api.Data;

/// <summary>
/// The Staged Upgrade Group containing the name and ID
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsCreateRequestStageGroup
{
	/// <summary>
	/// ID of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}