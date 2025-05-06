namespace Meraki.Api.Data;

/// <summary>
/// Switch Stack containing the name and id
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupAssignedSwitchStack
{
	/// <summary>
	/// ID of the Switch Stack
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Switch Stack
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? Name { get; set; }
}