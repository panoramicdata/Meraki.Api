namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Channel Utilization By Network Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesChannelUtilizationByNetworkItem
{
	/// <summary>
	/// Network for the given utilization metrics.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesChannelUtilizationNetwork Network { get; set; } = new();

	/// <summary>
	/// Channel utilization broken down by band.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "byBand")]
	public List<OrganizationWirelessDevicesChannelUtilizationByBandItem> ByBand { get; set; } = [];
}
