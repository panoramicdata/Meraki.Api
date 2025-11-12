namespace Meraki.Api.Sections.Products.Wireless;

public partial class WirelessSsidsSection
{
	[RefitPromoteCalls]
	internal IWirelessSsids Ssids { get; set; } = null!;
	/// <summary>
	/// List the Bonjour forwarding setting and rules for the SSID
	/// </summary>

	public IWirelessSsidsBonjourForwarding BonjourForwarding { get; internal set; } = null!;
	/// <summary>
	/// List the device type group policies for the SSID
	/// </summary>

	public IWirelessSsidsDeviceTypeGroupPolicies DeviceTypeGroupPolicies { get; internal set; } = null!;
	/// <summary>
	/// Return the EAP overridden parameters for an SSID
	/// </summary>

	public IWirelessSsidsEapOverride EapOverride { get; internal set; } = null!;
	/// <summary>
	/// Return the L7 firewall rules for an SSID on an MR network
	/// </summary>

	public IWirelessSsidsFirewall Firewall { get; internal set; } = null!;
	/// <summary>
	/// Return the Hotspot 2.0 settings for an SSID
	/// </summary>

	public IWirelessSsidsHotSpot20 HotSpot20 { get; internal set; } = null!;
	/// <summary>
	/// List all Identity PSKs in a wireless network
	/// </summary>

	public IWirelessSsidsIdentityPsks IdentityPsks { get; internal set; } = null!;
	/// <summary>
	/// List the outage schedule for the SSID
	/// </summary>

	public IWirelessSsidsSchedules Schedules { get; internal set; } = null!;
	/// <summary>
	/// Modify the splash page settings for the given SSID
	/// </summary>

	public IWirelessSsidsSplash Splash { get; internal set; } = null!;
	/// <summary>
	/// List status information of all BSSIDs in your organization
	/// </summary>

	public IWirelessSsidsStatuses Statuses { get; internal set; } = null!;
	/// <summary>
	/// Display the traffic shaping rules for a SSID on an MR network
	/// </summary>

	public IWirelessSsidsTrafficShaping TrafficShaping { get; internal set; } = null!;
	/// <summary>
	/// List the VPN settings for the SSID.
	/// </summary>

	public IWirelessSsidsVpn Vpn { get; internal set; } = null!;
}
