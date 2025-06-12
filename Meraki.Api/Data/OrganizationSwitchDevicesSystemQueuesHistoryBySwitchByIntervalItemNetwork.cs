namespace Meraki.Api.Data;

/// <summary>
/// Information regarding the network the switch belongs to
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemNetwork
{
	/// <summary>
	/// The network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// List of custom tags for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}