namespace Meraki.Api.Data;

/// <summary>
/// The usage on the interfaces of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItemIntervalByInterfaceItemUsage
{
	/// <summary>
	/// The received usage on the interface during the interval, unit is bit/sec
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "recv")]
	public int Recv { get; set; }

	/// <summary>
	/// The sent usage on the interface during the interval, unit is bit/sec
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "send")]
	public int Send { get; set; }

	/// <summary>
	/// The total usage on the interface during the interval, unit is bit/sec
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}