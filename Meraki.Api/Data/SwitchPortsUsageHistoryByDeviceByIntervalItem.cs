namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Usage History By Device By Interval Item
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItem
{
	/// <summary>
	/// The MAC address of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The model of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// The name of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Identifying information of the switch's network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public SwitchPortsUsageHistoryByDeviceByIntervalItemNetwork Network { get; set; } = new();

	/// <summary>
	/// The number of ports on the switch with usage data.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<SwitchPortsUsageHistoryByDeviceByIntervalItemPort> Ports { get; set; } = [];

}
