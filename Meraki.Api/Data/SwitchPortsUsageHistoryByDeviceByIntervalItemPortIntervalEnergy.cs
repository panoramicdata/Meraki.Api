namespace Meraki.Api.Data;

/// <summary>
/// How much energy (in watt-hours) has been delivered by this port during the interval.
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalEnergy
{
	/// <summary>
	/// Energy data for the given interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public SwitchPortsUsageHistoryByDeviceByIntervalItemPortIntervalEnergyUsage Usage { get; set; } = new();

}
