namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Signal Quality By Client Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSignalQualityByClientItem
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
	/// Client.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "client")]
	public OrganizationWirelessDevicesSignalQualityClient Client { get; set; } = new();

	/// <summary>
	/// Network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesSignalQualityNetwork Network { get; set; } = new();
}
