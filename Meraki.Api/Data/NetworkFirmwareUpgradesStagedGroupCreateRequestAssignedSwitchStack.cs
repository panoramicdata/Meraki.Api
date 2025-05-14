namespace Meraki.Api.Data;

/// <summary>
/// Switch Stack containing the name and id
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupCreateRequestAssignedSwitchStack
{
	/// <summary>
	/// ID of the Switch Stack
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Switch Stack
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}