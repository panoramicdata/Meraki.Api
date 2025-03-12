namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceSection
{
	public IApplianceConnectivityMonitoringDestinations ConnectivityMonitoringDestinations { get; internal set; } = null!;
	public ApplianceClientsSection Clients { get; internal set; } = new();
	public ApplianceContentFilteringSection ContentFiltering { get; internal set; } = new();
	public ApplianceDhcpSection Dhpc { get; internal set; } = new();
	public IApplianceDnsLocalProfiles DnsLocalProfiles { get; internal set; } = null!;
	public ApplianceFirewallSection Firewall { get; internal set; } = new();
	public IAppliancePerformance Performance { get; internal set; } = null!;
	public IAppliancePorts Ports { get; internal set; } = null!;
	public AppliancePrefixesSection Prefixes { get; internal set; } = new();
	public IApplianceRadioSettings RadioSettings { get; internal set; } = null!;
	public IApplianceRfProfiles RfProfiles { get; internal set; } = null!;
	public IApplianceSdwanInternetPolicies SdwanInternetPolices { get; internal set; } = null!;
	public ApplianceSecuritySection Security { get; internal set; } = new();
	public IApplianceSettings Settings { get; internal set; } = null!;
	public IApplianceSingleLan SingleLan { get; internal set; } = null!;
	public IApplianceStaticRoutes StaticRoutes { get; internal set; } = null!;
	public IApplianceSsids Ssids { get; internal set; } = null!;
	public ApplianceTrafficShapingSection TrafficShaping { get; internal set; } = new();
	public ApplianceUplinkSection Uplink { get; internal set; } = new();
	public ApplianceUplinksSection Uplinks { get; internal set; } = new();
	public ApplianceVlansSection Vlans { get; internal set; } = new();
	public ApplianceVpnSection Vpn { get; internal set; } = new();
	public IApplianceWarmSpare WarmSpare { get; internal set; } = null!;
}
