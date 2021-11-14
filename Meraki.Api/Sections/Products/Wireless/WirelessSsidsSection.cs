namespace Meraki.Api.Sections.Products.Wireless;

public class WirelessSsidsSection
{
	public IWirelessSsids Ssids { get; internal set; } = null!;
	public IWirelessSsidsFirewall Firewall { get; internal set; } = null!;
}
