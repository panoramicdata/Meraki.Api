namespace Meraki.Api.Sections.Products.Wireless;

public partial class WirelessSsidsSection
{
	[RefitPromoteCalls]
	internal IWirelessSsids Ssids { get; set; } = null!;
	public IWirelessSsidsBonjourForwarding BonjourForwarding { get; internal set; } = null!;
	public IWirelessSsidsDeviceTypeGroupPolicies DeviceTypeGroupPolicies { get; internal set; } = null!;
	public IWirelessSsidsEapOverride EapOverride { get; internal set; } = null!;
	public IWirelessSsidsFirewall Firewall { get; internal set; } = null!;
	public IWirelessSsidsHotSpot20 HotSpot20 { get; internal set; } = null!;
	public IWirelessSsidsIdentityPsks IdentityPsks { get; internal set; } = null!;
	public IWirelessSsidsSchedules Schedules { get; internal set; } = null!;
	public IWirelessSsidsSplash Splash { get; internal set; } = null!;
	public IWirelessSsidsStatuses Statuses { get; internal set; } = null!;
	public IWirelessSsidsTrafficShaping TrafficShaping { get; internal set; } = null!;
	public IWirelessSsidsVpn Vpn { get; internal set; } = null!;
}
