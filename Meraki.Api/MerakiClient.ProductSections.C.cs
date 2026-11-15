using Meraki.Api.Sections.General.LiveTools;
using Meraki.Api.Sections.Products.Licensing;
using Meraki.Api.Sections.SecureConnect;

namespace Meraki.Api;

public partial class MerakiClient
{
	private ApplianceFirewallSection BuildApplianceFirewallSection()
		=> new()
		{
			CellularFirewallRules = RefitFor(Appliance.Firewall.CellularFirewallRules),
			InboundCellularFirewallRules = RefitFor(Appliance.Firewall.InboundCellularFirewallRules),
			FirewalledServices = RefitFor(Appliance.Firewall.FirewalledServices),
			InboundFirewallRules = RefitFor(Appliance.Firewall.InboundFirewallRules),
			L3FirewallRules = RefitFor(Appliance.Firewall.L3FirewallRules),
			L7FirewallRules = RefitFor(Appliance.Firewall.L7FirewallRules),
			MulticastForwarding = RefitFor(Appliance.Firewall.MulticastForwarding),
			OneToManyNatRules = RefitFor(Appliance.Firewall.OneToManyNatRules),
			OneToOneNatRules = RefitFor(Appliance.Firewall.OneToOneNatRules),
			PortForwardingRules = RefitFor(Appliance.Firewall.PortForwardingRules),
			ApplianceFirewallSettings = RefitFor(Appliance.Firewall.ApplianceFirewallSettings)
		};

	private ApplianceTrafficShapingSection BuildApplianceTrafficShapingSection()
		=> new()
		{
			TrafficShaping = RefitFor(Appliance.TrafficShaping.TrafficShaping),
			CustomPerformanceClasses = RefitFor(Appliance.TrafficShaping.CustomPerformanceClasses),
			Rules = RefitFor(Appliance.TrafficShaping.Rules),
			UplinkBandwidth = RefitFor(Appliance.TrafficShaping.UplinkBandwidth),
			UplinkSelection = RefitFor(Appliance.TrafficShaping.UplinkSelection),
			VpnExclusions = RefitFor(Appliance.TrafficShaping.VpnExclusions)
		};

	private ApplianceVpnSection BuildApplianceVpnSection()
		=> new()
		{
			Bgp = RefitFor(Appliance.Vpn.Bgp),
			SiteToSiteVpn = RefitFor(Appliance.Vpn.SiteToSiteVpn),
			ThirdPartyVpnPeers = RefitFor(Appliance.Vpn.ThirdPartyVpnPeers),
			VpnFirewallRules = RefitFor(Appliance.Vpn.VpnFirewallRules),
			Stats = RefitFor(Appliance.Vpn.Stats),
			Statuses = RefitFor(Appliance.Vpn.Statuses)
		};

	private WirelessSsidsSection BuildWirelessSsidsSection()
		=> new()
		{
			Ssids = RefitFor(Wireless.Ssids.Ssids),
			BonjourForwarding = RefitFor(Wireless.Ssids.BonjourForwarding),
			DeviceTypeGroupPolicies = RefitFor(Wireless.Ssids.DeviceTypeGroupPolicies),
			EapOverride = RefitFor(Wireless.Ssids.EapOverride),
			Firewall = RefitFor(Wireless.Ssids.Firewall),
			HotSpot20 = RefitFor(Wireless.Ssids.HotSpot20),
			IdentityPsks = RefitFor(Wireless.Ssids.IdentityPsks),
			Schedules = RefitFor(Wireless.Ssids.Schedules),
			Splash = RefitFor(Wireless.Ssids.Splash),
			Statuses = RefitFor(Wireless.Ssids.Statuses),
			TrafficShaping = RefitFor(Wireless.Ssids.TrafficShaping),
			Vpn = RefitFor(Wireless.Ssids.Vpn)
		};

	private SmDevicesSection BuildSmDevicesSection()
		=> new()
		{
			Devices = RefitFor(Sm.Devices.Devices),
			BypassActivationLockAttempts = RefitFor(Sm.Devices.BypassActivationLockAttempts),
			CellularUsageHistory = RefitFor(Sm.Devices.CellularUsageHistory),
			Certs = RefitFor(Sm.Devices.Certs),
			Connectivity = RefitFor(Sm.Devices.Connectivity),
			DesktopLogs = RefitFor(Sm.Devices.DesktopLogs),
			DeviceCommandLogs = RefitFor(Sm.Devices.DeviceCommandLogs),
			DeviceProfiles = RefitFor(Sm.Devices.DeviceProfiles),
			Fields = RefitFor(Sm.Devices.Fields),
			NetworkAdapters = RefitFor(Sm.Devices.NetworkAdapters),
			PerformanceHistory = RefitFor(Sm.Devices.PerformanceHistory),
			Restrictions = RefitFor(Sm.Devices.Restrictions),
			SecurityCenters = RefitFor(Sm.Devices.SecurityCenters),
			Softwares = RefitFor(Sm.Devices.Softwares),
			WlanLists = RefitFor(Sm.Devices.WlanLists)
		};
	private AppliancePrefixesSection BuildAppliancePrefixesSection()
		=> new()
		{
			Delegated = new()
			{
				Statics = RefitFor(Appliance.Prefixes.Delegated.Statics)
			}
		};

	private ApplianceSecuritySection BuildApplianceSecuritySection()
		=> new()
		{
			Intrusion = RefitFor(Appliance.Security.Intrusion),
			Malware = RefitFor(Appliance.Security.Malware),
			Events = RefitFor(Appliance.Security.Events)
		};

	private ApplianceUplinksSection BuildApplianceUplinksSection()
		=> new()
		{
			UsageHistory = RefitFor(Appliance.Uplinks.UsageHistory),
			Settings = RefitFor(Appliance.Uplinks.Settings),
			StatusesOverview = RefitFor(Appliance.Uplinks.StatusesOverview)
		};

	private CameraAnalyticsSection BuildCameraAnalyticsSection()
		=> new()
		{
			Live = RefitFor(Camera.Analytics.Live),
			Overview = RefitFor(Camera.Analytics.Overview),
			Recent = RefitFor(Camera.Analytics.Recent),
			Zones = RefitFor(Camera.Analytics.Zones)
		};

	private SecureConnectDeploymentsSection BuildSecureConnectDeploymentsSection()
		=> new()
		{
			//DataCenter = RefitSecureConnectFor(SecureConnect.Deployments.DataCenter),
			NetworkDevices = RefitSecureConnectFor(SecureConnect.Deployments.NetworkDevices),
			OrganizationTunnel = RefitSecureConnectFor(SecureConnect.Deployments.OrganizationTunnel),
			//Policy = RefitSecureConnectFor(SecureConnect.Deployments.Policy)
		};

	private SwitchRoutingSection BuildSwitchRoutingSection()
		=> new()
		{
			Interfaces = RefitFor(Switch.Routing.Interfaces),
			Multicast = RefitFor(Switch.Routing.Multicast),
			Ospf = RefitFor(Switch.Routing.Ospf),
			StaticRoutes = RefitFor(Switch.Routing.StaticRoutes)
		};

	private WirelessClientsSection BuildWirelessClientsSection()
		=> new()
		{
			ConnectionStats = RefitFor(Wireless.Clients.ConnectionStats),
			ConnectivityEvents = RefitFor(Wireless.Clients.ConnectivityEvents),
			LatencyHistory = RefitFor(Wireless.Clients.LatencyHistory),
			LatencyStats = RefitFor(Wireless.Clients.LatencyStats)
		};

	private WirelessDevicesSection BuildWirelessDevicesSection()
		=> new()
		{
			ConnectionStats = RefitFor(Wireless.Devices.ConnectionStats),
			LatencyStats = RefitFor(Wireless.Devices.LatencyStats),
			OrganizationEthernetStatuses = RefitFor(Wireless.Devices.OrganizationEthernetStatuses),
			PacketLoss = RefitFor(Wireless.Devices.PacketLoss),
		};

	private SmUsersSection BuildSmUsersSection()
		=> new()
		{
			Users = RefitFor(Sm.Users.Users),
			DeviceProfiles = RefitFor(Sm.Users.DeviceProfiles),
			Softwares = RefitFor(Sm.Users.Softwares)
		};
}
