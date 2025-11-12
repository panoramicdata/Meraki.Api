namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsDeviceSection
{
	[RefitPromoteCalls]
	internal IOrganizationsDevices Devices { get; set; } = null!;

	/// <summary>
	/// Migrate devices to another controller or management mode
	/// </summary>

	public IOrganizationsDevicesController Controller { get; internal set; } = null!;

	/// <summary>
	/// List Packet Captures
	/// </summary>

	public IOrganizationsDevicesPacketCapture PacketCapture { get; internal set; } = null!;

	/// <summary>
	/// Return a record of power mode changes for wireless devices in the organization. For each device, it provides a series of events with timestamps indicating when a power mode change occurred and the new mode. The events are ordered by timestamp.
	/// </summary>

	public IOrganizationsDevicesPower Power { get; internal set; } = null!;

	/// <summary>
	/// Gets the power modules
	/// </summary>

	public OrganizationsDevicesPowerModulesSection PowerModules { get; internal set; } = new();

	/// <summary>
	/// Get average signal quality for all clients in the organization
	/// </summary>

	public IOrganizationsDevicesSignalQuality SignalQuality { get; internal set; } = null!;

	/// <summary>
	/// Gets the system
	/// </summary>

	public OrganizationsDevicesSystemSection System { get; internal set; } = new();

	/// <summary>
	/// Gets the syslog
	/// </summary>

	public OrganizationsDevicesSyslogSection Syslog { get; internal set; } = new();

	/// <summary>
	/// Gets the uplinks
	/// </summary>

	public OrganizationsDevicesUplinksSection Uplinks { get; internal set; } = new();

	/// <summary>
	/// List of Catalyst access points information
	/// </summary>

	public IOrganizationsDevicesWirelessControllers WirelessControllers { get; internal set; } = null!;

}
