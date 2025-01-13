namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Usage History By Device By Interval
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByInterval
	: ItemsResponseWithMeta<SwitchPortsUsageHistoryByDeviceByIntervalItem>
{
	/// <summary>
	/// List Switch Ports Usage by Device by Interval
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<SwitchPortsUsageHistoryByDeviceByIntervalItem> Items { get; set; } = [];

}
