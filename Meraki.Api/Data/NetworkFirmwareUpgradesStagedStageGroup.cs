namespace Meraki.Api.Data;

/// <summary>
/// The Staged Upgrade Group
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedStageGroup
{
	/// <summary>
	/// Description of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "description")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? Description { get; set; }

	/// <summary>
	/// Id of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? Name { get; set; }
}