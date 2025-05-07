namespace Meraki.Api.Data;

/// <summary>
/// Switch stack containing the name and id
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedGroupUpdateRequestSwitchStack
{
	/// <summary>
	/// ID of the Switch Stack
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the Switch Stack
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}