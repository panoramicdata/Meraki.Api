namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Signal Quality By Device Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSignalQualityByDeviceItem
{
	/// <summary>
	/// Received Signal Strength Indicator.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rssi")]
	public string Rssi { get; set; } = string.Empty;

	/// <summary>
	/// Signal to Noise Ratio.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "snr")]
	public string Snr { get; set; } = string.Empty;

	/// <summary>
	/// Network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesSignalQualityNetwork Network { get; set; } = new();
}
