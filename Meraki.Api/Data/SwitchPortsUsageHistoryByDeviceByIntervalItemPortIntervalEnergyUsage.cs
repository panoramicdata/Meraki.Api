namespace Meraki.Api.Data;

/// <summary>
/// Energy data for the given interval.
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalEnergyUsage
{
	/// <summary>
	/// The total energy in watt-hours delivered by this port during the interval
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public double Total { get; set; }
}
