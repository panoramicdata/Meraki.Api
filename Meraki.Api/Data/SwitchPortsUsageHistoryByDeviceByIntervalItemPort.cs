namespace Meraki.Api.Data;

/// <summary>
/// The number of ports on the switch with usage data.
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemPort
{
	/// <summary>
	/// The string identifier of this port on the switch. 
	/// This is commonly just the port number but may contain additional identifying information 
	/// such as the slot and module-type if the port is located on a port module.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// An array of intervals for a port with bandwidth, traffic, and power usage data.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "intervals")]
	public List<SwitchPortsUsageHistoryByDeviceByIntervalItemPortInterval> Intervals { get; set; } = [];

}
