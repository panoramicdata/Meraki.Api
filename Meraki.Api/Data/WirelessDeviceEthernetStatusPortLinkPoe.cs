namespace Meraki.Api.Data;

/// <summary>
/// Wireless Device Ethernet Status Port Poe Details
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatusPortPoe
{
	/// <summary>
	/// The PoE Standard for the port. Can be '802.3at', '802.3af',802.3bt' or null
	/// </summary>
	[DataMember(Name = "standard")]
	public WirelessDeviceEthernetStatusPortPoeStandard Standard { get; set; }
}
