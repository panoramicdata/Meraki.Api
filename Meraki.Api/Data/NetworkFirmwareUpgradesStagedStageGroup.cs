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
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Description { get; set; }

	/// <summary>
	/// Id of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.Read)]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Name { get; set; }
}