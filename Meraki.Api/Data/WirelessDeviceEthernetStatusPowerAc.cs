namespace Meraki.Api.Data;

/// <summary>
/// Wireless Device Ethernet Status AC power details object
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatusPowerAc
{
	/// <summary>
	/// AC Power Connected
	/// </summary>
	[DataMember(Name = "isConnected")]
	public bool IsConnected { get; set; }
}
