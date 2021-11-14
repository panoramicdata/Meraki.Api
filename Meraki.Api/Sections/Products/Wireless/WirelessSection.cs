
namespace Meraki.Api.Sections.Products.Wireless;

public class WirelessSection
{
	public IWirelessAirMarshal AirMarshal { get; internal set; } = null!;
	public IWirelessBilling Billing { get; internal set; } = null!;
	public IWirelessChannelUtilizationHistory ChannelUtilizationHistory { get; internal set; } = null!;
	public WirelessClientsSection Clients { get; internal set; } = null!;
	public IWirelessClientCountHistory ClientCountHistory { get; internal set; } = null!;
	public IWirelessRfProfiles RfProfiles { get; internal set; } = null!;
	public WirelessRadioSection Radio { get; internal set; } = new();
	public WirelessSsidsSection Ssids { get; internal set; } = new();
}
