namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Channel Utilization By Device Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesChannelUtilizationByDeviceItem
{
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
