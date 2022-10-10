namespace Meraki.Api.Data;

/// <summary>
/// Wireless Device Ethernet Status Port Link Negotiation Details
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatusPortLinkNegotiation
{
	/// <summary>
	/// The speed of the port in Mbps
	/// </summary>
	[DataMember(Name = "speed")]
	public int SpeedMbps { get; set; }

	/// <summary>
	/// The duplex mode of the port, can be 'full' or 'half'
	/// </summary>
	[DataMember(Name = "duplex")]
	public WirelessDeviceEthernetStatusPortLinkNegotiationDuplex Duplex { get; set; }
}
