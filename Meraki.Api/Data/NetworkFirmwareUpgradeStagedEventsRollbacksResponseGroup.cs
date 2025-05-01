namespace Meraki.Api.Data;

/// <summary>
/// The staged upgrade group
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsRollbacksResponseGroup
{
	/// <summary>
	/// Description of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Id of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}