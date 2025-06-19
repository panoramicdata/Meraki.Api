namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Signal Quality By Network Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSignalQualityByNetworkItem
{
	/// <summary>
	/// Received Signal Strength Indicator.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rssi")]
	public int Rssi { get; set; }

	/// <summary>
	/// Signal to Noise Ratio.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "snr")]
	public int Snr { get; set; }

	/// <summary>
	/// Network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesSignalQualityNetwork Network { get; set; } = new();
}
