namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance API endpoints
/// </summary>
public class ApplianceSection
{
	/// <summary>
	/// Return the connectivity testing destinations for an MX network
	/// </summary>

	public IApplianceConnectivityMonitoringDestinations ConnectivityMonitoringDestinations { get; internal set; } = null!;
	/// <summary>
	/// Gets the clients
	/// </summary>

	public ApplianceClientsSection Clients { get; internal set; } = new();
	/// <summary>
	/// Gets the content filtering
	/// </summary>

	public ApplianceContentFilteringSection ContentFiltering { get; internal set; } = new();
	/// <summary>
	/// Gets the DHCP
	/// </summary>

	public ApplianceDhcpSection Dhcp { get; internal set; } = new();
	/// <summary>
	/// Create a new local DNS profile
	/// </summary>

	public IApplianceDnsLocalProfiles DnsLocalProfiles { get; internal set; } = null!;
	/// <summary>
	/// Gets the firewall
	/// </summary>

	public ApplianceFirewallSection Firewall { get; internal set; } = new();
	/// <summary>
	/// Return the performance score for a single MX
	/// </summary>

	public IAppliancePerformance Performance { get; internal set; } = null!;
	/// <summary>
	/// Return per-port VLAN settings for a single MX port.
	/// </summary>

	public IAppliancePorts Ports { get; internal set; } = null!;
	/// <summary>
	/// Gets the prefixes
	/// </summary>

	public AppliancePrefixesSection Prefixes { get; internal set; } = new();
	/// <summary>
	/// Return the radio settings of an appliance
	/// </summary>

	public IApplianceRadioSettings RadioSettings { get; internal set; } = null!;
	/// <summary>
	/// List the RF profiles for this network
	/// </summary>

	public IApplianceRfProfiles RfProfiles { get; internal set; } = null!;
	/// <summary>
	/// Update SDWAN internet traffic preferences for an MX network
	/// </summary>

	public IApplianceSdwanInternetPolicies SdwanInternetPolices { get; internal set; } = null!;
	/// <summary>
	/// Gets the security
	/// </summary>

	public ApplianceSecuritySection Security { get; internal set; } = new();
	/// <summary>
	/// Return the appliance settings for a network
	/// </summary>

	public IApplianceSettings Settings { get; internal set; } = null!;
	/// <summary>
	/// Return single LAN configuration
	/// </summary>

	public IApplianceSingleLan SingleLan { get; internal set; } = null!;
	/// <summary>
	/// Return a static route for an MX or teleworker network
	/// </summary>

	public IApplianceStaticRoutes StaticRoutes { get; internal set; } = null!;
	/// <summary>
	/// Return a single MX SSID
	/// </summary>

	public IApplianceSsids Ssids { get; internal set; } = null!;
	/// <summary>
	/// Gets the traffic shaping
	/// </summary>

	public ApplianceTrafficShapingSection TrafficShaping { get; internal set; } = new();
	/// <summary>
	/// Gets the uplink
	/// </summary>

	public ApplianceUplinkSection Uplink { get; internal set; } = new();
	/// <summary>
	/// Gets the uplinks
	/// </summary>

	public ApplianceUplinksSection Uplinks { get; internal set; } = new();
	/// <summary>
	/// Gets the vlans
	/// </summary>

	public ApplianceVlansSection Vlans { get; internal set; } = new();
	/// <summary>
	/// Gets the vpn
	/// </summary>

	public ApplianceVpnSection Vpn { get; internal set; } = new();
	/// <summary>
	/// Return MX warm spare settings
	/// </summary>

	public IApplianceWarmSpare WarmSpare { get; internal set; } = null!;
}
