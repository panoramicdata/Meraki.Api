namespace Meraki.Api.Sections.General.Devices;

/// <summary>
/// Provides access to devices API endpoints
/// </summary>
public partial class DevicesSection
{
	[RefitPromoteCalls]
	internal IDevices Devices { get; set; } = null!;

	/// <summary>
	/// Gets the appliance
	/// </summary>

	public DevicesApplianceSection Appliance { get; set; } = null!;

	/// <summary>
	/// List the clients of a device, up to a maximum of a month ago
	/// </summary>

	public IDeviceClients Clients { get; internal set; } = null!;

	/// <summary>
	/// Return the SIM and APN configurations for a cellular device.
	/// </summary>

	public IDeviceCellularSims CellularSims { get; internal set; } = null!;

	/// <summary>
	/// List LLDP and CDP information for a device
	/// </summary>

	public IDeviceLldpCdp LldpCdp { get; internal set; } = null!;

	/// <summary>
	/// Get the uplink loss percentage and latency in milliseconds, and goodput in kilobits per second for a wired network device.
	/// </summary>

	public IDeviceLossAndLatencyHistory LossAndLatencyHistory { get; internal set; } = null!;

	/// <summary>
	/// Return the management interface settings for a device
	/// </summary>

	public IDeviceManagementInterface ManagementInterface { get; internal set; } = null!;

	/// <summary>
	/// Gets the wireless
	/// </summary>

	public DevicesWirelessSection Wireless { get; internal set; } = null!;

	/// <summary>
	/// Returns a historical log of all commands
	/// </summary>

	public IDeviceSensorCommands SensorCommands { get; internal set; } = null!;
}
