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
	[ApiAccess(ApiAccess.Create)]
	public string? Description { get; set; }

	/// <summary>
	/// Id of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.Create)]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Create)]
	public string? Name { get; set; }
}