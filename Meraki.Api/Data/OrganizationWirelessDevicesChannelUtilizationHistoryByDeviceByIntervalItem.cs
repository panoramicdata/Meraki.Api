namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Channel Utilization History By Device By Interval Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesChannelUtilizationHistoryByDeviceByIntervalItem
{
	/// <summary>
	/// The end time of the channel utilization interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// The MAC address of the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The serial number for the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// The start time of the channel utilization interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Network for the given utilization metrics.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesChannelUtilizationNetwork Network { get; set; } = new();

	/// <summary>
	/// Channel utilization broken down by band.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byBand")]
	public List<OrganizationWirelessDevicesChannelUtilizationByBandItem> ByBand { get; set; } = [];
}
