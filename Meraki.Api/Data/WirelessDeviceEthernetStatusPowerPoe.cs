namespace Meraki.Api.Data;

/// <summary>
/// Wireless Device Ethernet Status PoE power details object
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatusPowerPoe
{
	/// <summary>
	/// PoE Power Connected
	/// </summary>
	[DataMember(Name = "isConnected")]
	public bool IsConnected { get; set; }
}
