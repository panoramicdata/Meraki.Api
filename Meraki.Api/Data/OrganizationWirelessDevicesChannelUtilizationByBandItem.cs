namespace Meraki.Api.Data;

/// <summary>
/// Channel band
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesChannelUtilizationByBandItem
{
	/// <summary>
	/// The band for the given metrics.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "band")]
	public string Band { get; set; } = string.Empty;

	/// <summary>
	/// An object containing non-wifi utilization.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "nonWifi")]
	public OrganizationWirelessDevicesChannelUtilizationByBandItemNonWifi NonWifi { get; set; } = new();

	/// <summary>
	/// An object containing total channel utilization.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public OrganizationWirelessDevicesChannelUtilizationByBandItemTotal Total { get; set; } = new();

	/// <summary>
	/// An object containing wifi utilization.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wifi")]
	public OrganizationWirelessDevicesChannelUtilizationByBandItemWifi Wifi { get; set; } = new();
}
