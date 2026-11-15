
namespace Meraki.Api;

public partial class MerakiClient
{
	private OrganizationsApiPushSection BuildOrganizationsApiPushSection()
		=> new()
		{
			Topics = RefitFor(Organizations.Api.Push.Topics),
			Receivers = new()
			{
				Profiles = RefitFor(Organizations.Api.Push.Receivers.Profiles)
			},
			Profiles = RefitFor(Organizations.Api.Push.Profiles)
		};

	private OrganizationsConfigTemplatesSwitchSection BuildOrganizationsConfigTemplatesSwitchSection()
		=> new()
		{
			Profiles = new()
			{
				Ports = new()
				{
					Mirrors = RefitFor(Organizations.ConfigTemplates.Switch.Profiles.Ports.Mirrors)
				}
			}
		};

	private OrganizationsDevicesSystemSection BuildOrganizationsDevicesSystemSection()
		=> new()
		{
			System = RefitFor(Organizations.Devices.System.System),
			Memory = new()
			{
				Usage = new()
				{
					History = RefitFor(Organizations.Devices.System.Memory.Usage.History),
				}
			}
		};

	private OrganizationsDevicesSyslogSection BuildOrganizationsDevicesSyslogSection()
		=> new()
		{
			Servers = new()
			{
				Roles = RefitFor(Organizations.Devices.Syslog.Servers.Roles),
			}
		};

	private OrganizationsWirelessDevicesSection BuildOrganizationsWirelessDevicesSection()
		=> new()
		{
			ChannelUtilization = RefitFor(Organizations.Wireless.Devices.ChannelUtilization),
			Latency = RefitFor(Organizations.Wireless.Devices.Latency),
			PacketLoss = RefitFor(Organizations.Wireless.Devices.PacketLoss),
			Radio = RefitFor(Organizations.Wireless.Devices.Radio),
			Radsec = new()
			{
				Certificates = RefitFor(Organizations.Wireless.Devices.Radsec.Certificates)
			}
		};

	private OrganizationsWirelessSsidsSection BuildOrganizationsWirelessSsidsSection()
		=> new()
		{
			Firewall = new()
			{
				Isolation = RefitFor(Organizations.Wireless.Ssids.Firewall.Isolation)
			}
		};

	private OrganizationsApplianceDnsLocalSection BuildOrganizationsApplianceDnsLocalSection()
		=> new()
		{
			Profiles = RefitFor(Organizations.Appliance.Dns.Local.Profiles),
			Records = RefitFor(Organizations.Appliance.Dns.Local.Records)
		};

	private OrganizationsCampusGatewayDevices BuildOrganizationsCampusGatewayDevicesSection()
		=> new()
		{
			Uplinks = new()
			{
				LocalOverrides = RefitFor(Organizations.CampusGateway.Devices.Uplinks.LocalOverrides)
			}
		};

	private OrganizationsWirelessControllerClientsOverview BuildOrganizationsWirelessControllerClientsOverviewSection()
		=> new()
		{
			History = new()
			{
				ByDevice = RefitFor(Organizations.WirelessController.Clients.Overview.History.ByDevice)
			}
		};

	private OrganizationsWirelessControllerDevicesInterfacesSection BuildOrganizationsWirelessControllerDevicesInterfacesSection()
		=> new()
		{
			L2 = RefitFor(Organizations.WirelessController.Devices.Interfaces.L2),
			L3 = RefitFor(Organizations.WirelessController.Devices.Interfaces.L3),
			Packets = RefitFor(Organizations.WirelessController.Devices.Interfaces.Packets),
			Usage = RefitFor(Organizations.WirelessController.Devices.Interfaces.Usage)
		};

	private OrganizationsWirelessControllerDevicesSystemSection BuildOrganizationsWirelessControllerDevicesSystemSection()
		=> new()
		{
			Utilization = new()
			{
				History = RefitFor(Organizations.WirelessController.Devices.System.Utilization.History)
			}
		};
}
