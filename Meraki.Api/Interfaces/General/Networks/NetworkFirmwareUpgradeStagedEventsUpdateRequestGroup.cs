namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// The Staged Upgrade Group containing the name and ID
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsUpdateRequestGroup
{
	/// <summary>
	/// ID of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}