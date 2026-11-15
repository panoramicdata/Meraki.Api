using Meraki.Api.Sections.General.LiveTools;
using Meraki.Api.Sections.Products.Licensing;
using Meraki.Api.Sections.SecureConnect;

namespace Meraki.Api;

/// <summary>
/// Builds the product-level API sections, one per Meraki product family.
/// </summary>
/// <remarks>
/// These are separated from the constructor, which was otherwise 555 lines of wiring. Each builder
/// reads the section property it is about to replace, because <c>RefitFor</c> uses the value only
/// to infer the interface type to generate an implementation for.
/// </remarks>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). The remaining parts live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class MerakiClient
{
	private ApplianceSection BuildApplianceSection()
		=> new()
		{
			Clients = new()
			{
				Security = RefitFor(Appliance.Clients.Security)
			},
			ConnectivityMonitoringDestinations = RefitFor(Appliance.ConnectivityMonitoringDestinations),
			ContentFiltering = new()
			{
				ContentFiltering = RefitFor(Appliance.ContentFiltering.ContentFiltering),
				Categories = RefitFor(Appliance.ContentFiltering.Categories)
			},
			Performance = RefitFor(Appliance.Performance),
			Ports = RefitFor(Appliance.Ports),
			Prefixes = BuildAppliancePrefixesSection(),
			RadioSettings = RefitFor(Appliance.RadioSettings),
			RfProfiles = RefitFor(Appliance.RfProfiles),
			SdwanInternetPolices = RefitFor(Appliance.SdwanInternetPolices),
			Security = BuildApplianceSecuritySection(),
			Settings = RefitFor(Appliance.Settings),
			SingleLan = RefitFor(Appliance.SingleLan),
			Dhcp = new()
			{
				Subnets = RefitFor(Appliance.Dhcp.Subnets)
			},
			DnsLocalProfiles = RefitFor(Appliance.DnsLocalProfiles),
			Firewall = BuildApplianceFirewallSection(),
			StaticRoutes = RefitFor(Appliance.StaticRoutes),
			Ssids = RefitFor(Appliance.Ssids),
			TrafficShaping = BuildApplianceTrafficShapingSection(),
			Uplink = new()
			{
				Statuses = RefitFor(Appliance.Uplink.Statuses)
			},
			Uplinks = BuildApplianceUplinksSection(),
			Vlans = new()
			{
				Vlans = RefitFor(Appliance.Vlans.Vlans),
				Settings = RefitFor(Appliance.Vlans.Settings)
			},
			Vpn = BuildApplianceVpnSection(),
			WarmSpare = RefitFor(Appliance.WarmSpare)
		};

	private CameraSection BuildCameraSection()
		=> new()
		{
			Camera = RefitFor(Camera.Camera),
			Analytics = BuildCameraAnalyticsSection(),
			Boundaries = RefitFor(Camera.Boundaries),
			QualityAndRetention = RefitFor(Camera.QualityAndRetention),
			Sense = new()
			{
				Sense = RefitFor(Camera.Sense.Sense)
			},
			Video = new()
			{
				Video = RefitFor(Camera.Video.Video)
			},
			VideoLink = RefitFor(Camera.VideoLink),
			WirelessProfiles = RefitFor(Camera.WirelessProfiles),
			QualityAndRetentionProfiles = RefitFor(Camera.QualityAndRetentionProfiles),
			Schedules = RefitFor(Camera.Schedules),
			Onbording = new()
			{
				Onbording = RefitFor(Camera.Onbording.Onbording)
			},
			Roles = RefitFor(Camera.Roles)
		};

	private CellularGatewaySection BuildCellularGatewaySection()
		=> new()
		{
			ConnectivityMonitoringDestinations = RefitFor(CellularGateway.ConnectivityMonitoringDestinations),
			Dhcp = RefitFor(CellularGateway.Dhcp),
			Esims = RefitFor(CellularGateway.Esims),
			Lan = RefitFor(CellularGateway.Lan),
			PortForwardingRules = RefitFor(CellularGateway.PortForwardingRules),
			SubnetPool = RefitFor(CellularGateway.SubnetPool),
			Uplink = new()
			{
				Uplink = RefitFor(CellularGateway.Uplink.Uplink),
				Statuses = RefitFor(CellularGateway.Uplink.Statuses)
			}
		};

	private SecureConnectSection BuildSecureConnectSection()
		=> new()
		{
			Deployments = BuildSecureConnectDeploymentsSection(),
			Policies = new()
			{
				DestinationLists = RefitSecureConnectFor(SecureConnect.Policies.DestinationLists),
				Destinations = RefitSecureConnectFor(SecureConnect.Policies.Destinations)
			}
		};

	private SwitchSection BuildSwitchSection()
		=> new()
		{
			AccessControlLists = RefitFor(Switch.AccessControlLists),
			AccessPolicies = RefitFor(Switch.AccessPolicies),
			AlternateManagementInterface = RefitFor(Switch.AlternateManagementInterface),
			Devices = RefitFor(Switch.Devices),
			DscpToCosMappings = RefitFor(Switch.DscpToCosMappings),
			DhcpServerPolicy = RefitFor(Switch.DhcpServerPolicy),
			ConfigTemplates = new()
			{
				Profiles = RefitFor(Switch.ConfigTemplates.Profiles)
			},
			Mtu = RefitFor(Switch.Mtu),
			LinkAggregations = RefitFor(Switch.LinkAggregations),
			Ports = RefitFor(Switch.Ports),
			PortSchedules = RefitFor(Switch.PortSchedules),
			QosRules = RefitFor(Switch.QosRules),
			Routing = BuildSwitchRoutingSection(),
			Settings = RefitFor(Switch.Settings),
			Stacks = RefitFor(Switch.Stacks),
			StormControl = RefitFor(Switch.StormControl),
			Stp = RefitFor(Switch.Stp),
			WarmSpare = RefitFor(Switch.WarmSpare)
		};
}
