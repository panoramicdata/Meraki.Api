namespace Meraki.Api.Sections.Products.Sm;

/// <summary>
/// Provides access to sm devices API endpoints
/// </summary>

public partial class SmDevicesSection
{
	[RefitPromoteCalls]
	internal ISmDevices Devices { get; set; } = null!;
	/// <summary>
	/// Bypass activation lock attempt
	/// </summary>

	public ISmDevicesBypassActivationLockAttempts BypassActivationLockAttempts { get; internal set; } = null!;
	/// <summary>
	/// Return the client's daily cellular data usage history
	/// </summary>

	public ISmDevicesCellularUsageHistory CellularUsageHistory { get; internal set; } = null!;
	/// <summary>
	/// List the certs on a device
	/// </summary>

	public ISmDevicesCerts Certs { get; internal set; } = null!;
	/// <summary>
	/// Returns historical connectivity data (whether a device is regularly checking in to Dashboard).
	/// </summary>

	public ISmDevicesConnectivity Connectivity { get; internal set; } = null!;
	/// <summary>
	/// Return historical records of various Systems Manager network connection details for desktop devices.
	/// </summary>

	public ISmDevicesDesktopLogs DesktopLogs { get; internal set; } = null!;
	/// <summary>
	/// Return historical records of commands sent to Systems Manager devices
	/// </summary>

	public ISmDevicesDeviceCommandLogs DeviceCommandLogs { get; internal set; } = null!;
	/// <summary>
	/// Get the installed profiles associated with a device
	/// </summary>

	public ISmDevicesDeviceProfiles DeviceProfiles { get; internal set; } = null!;
	/// <summary>
	/// Modify the fields of a device
	/// </summary>

	public ISmDevicesFields Fields { get; internal set; } = null!;
	/// <summary>
	/// List the network adapters of a device
	/// </summary>

	public ISmDevicesNetworkAdapters NetworkAdapters { get; internal set; } = null!;
	/// <summary>
	/// Return historical records of various Systems Manager client metrics for desktop devices.
	/// </summary>

	public ISmDevicesPerformanceHistory PerformanceHistory { get; internal set; } = null!;
	/// <summary>
	/// List the restrictions on a device
	/// </summary>

	public ISmDevicesRestrictions Restrictions { get; internal set; } = null!;
	/// <summary>
	/// List the security centers on a device
	/// </summary>

	public ISmDevicesSecurityCenters SecurityCenters { get; internal set; } = null!;
	/// <summary>
	/// Get a list of softwares associated with a device
	/// </summary>

	public ISmDevicesSoftwares Softwares { get; internal set; } = null!;
	/// <summary>
	/// List the saved SSID names on a device
	/// </summary>

	public ISmDevicesWlanLists WlanLists { get; internal set; } = null!;
}
