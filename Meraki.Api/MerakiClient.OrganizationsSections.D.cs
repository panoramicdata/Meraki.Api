
namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public partial class MerakiClient
{
	private OrganizationsInventorySection BuildOrganizationsInventorySection()
		=> new()
		{
			Onboarding = new()
			{
				CloudMonitoring = RefitFor(Organizations.Inventory.Onboarding.CloudMonitoring)
			},
			Orders = RefitFor(Organizations.Inventory.Orders)
		};

	private OrganizationsNacSection BuildOrganizationsNacSection()
		=> new()
		{
			Authorization = RefitFor(Organizations.Nac.Authorization),
			Sessions = RefitFor(Organizations.Nac.Sessions)
		};

	private OrganizationsPoliciesSection BuildOrganizationsPoliciesSection()
		=> new()
		{
			Assignments = RefitFor(Organizations.Policies.Assignments)
		};

	private OrganizationsSaseSection BuildOrganizationsSaseSection()
		=> new()
		{
			Connectivity = RefitFor(Organizations.Sase.Connectivity)
		};

	private OrganizationsSmSection BuildOrganizationsSmSection()
		=> new()
		{
			Admins = RefitFor(Organizations.Sm.Admins),
			Apple = RefitFor(Organizations.Sm.Apple),
			BulkEnrollment = RefitFor(Organizations.Sm.BulkEnrollment),
			Sentry = RefitFor(Organizations.Sm.Sentry)
		};

	private OrganizationsSpacesSection BuildOrganizationsSpacesSection()
		=> new()
		{
			Integration = RefitFor(Organizations.Spaces.Integration)
		};

	private OrganizationsWirelessControllerSection BuildOrganizationsWirelessControllerSection()
		=> new()
		{
			WirelessController = RefitFor(Organizations.WirelessController.WirelessController),
			Connections = RefitFor(Organizations.WirelessController.Connections),
			Clients = BuildOrganizationsWirelessControllerClientsSection(),
			Devices = BuildOrganizationsWirelessControllerDevicesSection(),
			Availabilities = RefitFor(Organizations.WirelessController.Availabilities),
			Overview = RefitFor(Organizations.WirelessController.Overview)
		};

	private OrganizationsWirelessControllerClientsSection BuildOrganizationsWirelessControllerClientsSection()
		=> new()
		{
			Overview = BuildOrganizationsWirelessControllerClientsOverviewSection()
		};

	private OrganizationsWirelessControllerDevicesSection BuildOrganizationsWirelessControllerDevicesSection()
		=> new()
		{
			Interfaces = BuildOrganizationsWirelessControllerDevicesInterfacesSection(),
			Redundancy = RefitFor(Organizations.WirelessController.Devices.Redundancy),
			System = BuildOrganizationsWirelessControllerDevicesSystemSection()
		};
	private NetworksAlertsSection BuildNetworksAlertsSection()
		=> new()
		{
			NetworksAlerts = RefitFor(Networks.Alerts.NetworksAlerts),
			Settings = RefitFor(Networks.Alerts.Settings)
		};
}
