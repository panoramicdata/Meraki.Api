namespace Meraki.Api.Data;

/// <summary>
/// The overall usage of all queried interfaces of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItemIntervalOverall
{
	/// <summary>
	/// The received usage of all queried interfaces during the interval, unit is bit/sec
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "recv")]
	public int Recv { get; set; }

	/// <summary>
	/// The sent usage of all queried interfaces during the interval, unit is bit/sec
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "send")]
	public int Send { get; set; }

	/// <summary>
	/// The total usage of all queried interfaces during the interval, unit is bit/sec
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}