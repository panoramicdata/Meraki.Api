
namespace Meraki.Api;

public partial class MerakiClient
{
	private OrganizationsSecureConnectSection BuildOrganizationsSecureConnectSection()
		=> new()
		{
			PrivateApplicationGroups = RefitFor(Organizations.SecureConnect.PrivateApplicationGroups),
			PrivateApplications = RefitFor(Organizations.SecureConnect.PrivateApplications),
			PrivateResourceGroups = RefitFor(Organizations.SecureConnect.PrivateResourceGroups),
			PrivateResources = RefitFor(Organizations.SecureConnect.PrivateResources),
			PublicApplications = RefitFor(Organizations.SecureConnect.PublicApplications),
			Regions = RefitFor(Organizations.SecureConnect.Regions),
			RemoteAccessLog = RefitFor(Organizations.SecureConnect.RemoteAccessLog),
			RemoteAccessLogsExports = RefitFor(Organizations.SecureConnect.RemoteAccessLogsExports),
			Sites = RefitFor(Organizations.SecureConnect.Sites)
		};

	private OrganizationsWirelessSection BuildOrganizationsWirelessSection()
		=> new()
		{
			LocationScanning = RefitFor(Organizations.Wireless.LocationScanning),
			Zigbee = RefitFor(Organizations.Wireless.Zigbee),
			Clients = RefitFor(Organizations.Wireless.Clients),
			Certificates = new()
			{
				OpenRoaming = RefitFor(Organizations.Wireless.Certificates.OpenRoaming)
			},
			Devices = BuildOrganizationsWirelessDevicesSection(),
			OpportunisticPcap = RefitFor(Organizations.Wireless.OpportunisticPcap),
			Mqtt = RefitFor(Organizations.Wireless.Mqtt),
			Ssids = BuildOrganizationsWirelessSsidsSection()
		};

	private OrganizationsApplianceDnsSection BuildOrganizationsApplianceDnsSection()
		=> new()
		{
			Local = BuildOrganizationsApplianceDnsLocalSection(),
			Split = new()
			{
				Profiles = RefitFor(Organizations.Appliance.Dns.Split.Profiles)
			}
		};

	private OrganizationsVpnSection BuildOrganizationsVpnSection()
		=> new()
		{
			SiteToSite = new()
			{
				Ipsec = RefitFor(Organizations.Appliance.Vpn.SiteToSite.Ipsec)
			}
		};

	private OrganizationsClientsSection BuildOrganizationsClientsSection()
		=> new()
		{
			Clients = RefitFor(Organizations.Clients.Clients),
			BandwidthUsageHistory = RefitFor(Organizations.Clients.BandwidthUsageHistory),
			Overview = RefitFor(Organizations.Clients.Overview),
		};

	private OrganizationsWebhooksSection BuildOrganizationsWebhooksSection()
		=> new()
		{
			AlertTypes = RefitFor(Organizations.Webhooks.AlertTypes),
			Callbacks = RefitFor(Organizations.Webhooks.Callbacks),
			Logs = RefitFor(Organizations.Webhooks.Logs),
			PayloadTemplates = RefitFor(Organizations.Webhooks.PayloadTemplates),
			HttpServers = RefitFor(Organizations.Webhooks.HttpServers),
			WebhookTests = RefitFor(Organizations.Webhooks.WebhookTests)
		};
}
