namespace Meraki.Api.Sections.General.Organizations;
/// <summary>
/// Provides access to organizations wireless API endpoints
/// </summary>
public class OrganizationsWirelessSection
{
	/// <summary>
	/// Return scanning API settings
	/// </summary>

	public IOrganizationsWirelessLocationScanning LocationScanning { get; internal set; } = null!;

	/// <summary>
	/// Return list of Zigbee configs
	/// </summary>

	public IOrganizationsWirelessZigbee Zigbee { get; internal set; } = null!;

	/// <summary>
	/// List access point client count at the moment in an organization
	/// </summary>

	public IOrganizationsWirelessClients Clients { get; internal set; } = null!;

	/// <summary>
	/// Gets the certificates
	/// </summary>

	public OrganizationsWirelessCertificatesSection Certificates { get; set; } = new();

	/// <summary>
	/// Return a single device
	/// </summary>

	public OrganizationsWirelessDevicesSection Devices { get; internal set; } = new();

	/// <summary>
	/// List the Opportunistic Pcap settings of an organization by network
	/// </summary>

	public IOrganizationsWirelessOpportunisticPcap OpportunisticPcap { get; internal set; } = null!;

	/// <summary>
	/// Return MQTT Settings for networks
	/// </summary>

	public IOrganizationsWirelessMqtt Mqtt { get; internal set; } = null!;

	/// <summary>
	/// Gets the ssids
	/// </summary>

	public OrganizationsWirelessSsidsSection Ssids { get; internal set; } = new();
}
