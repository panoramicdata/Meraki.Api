namespace Meraki.Api.Data;

/// <summary>
/// Information about the stack for which the switch is the active node
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStack
{
	/// <summary>
	/// ID of the switch stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the switch stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Information about the member devices in the switch stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "members")]
	public List<OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMember> Members { get; set; } = [];
}
