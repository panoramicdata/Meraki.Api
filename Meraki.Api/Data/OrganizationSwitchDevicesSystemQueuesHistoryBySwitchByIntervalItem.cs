namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Devices System Queues History By Switch By Interval Item
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItem
{
	/// <summary>
	/// MAC address of the switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Model of the switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Name of the switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Unique serial number for the switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// List of custom tags for the switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Information regarding the network the switch belongs to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Information about the stack for which the switch is the active node
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "stack")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStack Stack { get; set; } = new();

	/// <summary>
	/// The history of switch system data, with the most recent snapshot first
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "history")]
	public List<OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistory> History { get; set; } = [];
}
