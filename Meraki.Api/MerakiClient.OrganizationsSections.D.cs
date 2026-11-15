
namespace Meraki.Api;

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
