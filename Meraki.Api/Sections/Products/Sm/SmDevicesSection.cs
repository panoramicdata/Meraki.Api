namespace Meraki.Api.Sections.Products.Sm;

public partial class SmDevicesSection
{
	[RefitPromoteCalls]
	internal ISmDevices Devices { get; set; } = null!;
	public ISmDevicesBypassActivationLockAttempts BypassActivationLockAttempts { get; internal set; } = null!;
	public ISmDevicesCellularUsageHistory CellularUsageHistory { get; internal set; } = null!;
	public ISmDevicesCerts Certs { get; internal set; } = null!;
	public ISmDevicesConnectivity Connectivity { get; internal set; } = null!;
	public ISmDevicesDesktopLogs DesktopLogs { get; internal set; } = null!;
	public ISmDevicesDeviceCommandLogs DeviceCommandLogs { get; internal set; } = null!;
	public ISmDevicesDeviceProfiles DeviceProfiles { get; internal set; } = null!;
	public ISmDevicesFields Fields { get; internal set; } = null!;
	public ISmDevicesNetworkAdapters NetworkAdapters { get; internal set; } = null!;
	public ISmDevicesPerformanceHistory PerformanceHistory { get; internal set; } = null!;
	public ISmDevicesRestrictions Restrictions { get; internal set; } = null!;
	public ISmDevicesSecurityCenters SecurityCenters { get; internal set; } = null!;
	public ISmDevicesSoftwares Softwares { get; internal set; } = null!;
	public ISmDevicesWlanLists WlanLists { get; internal set; } = null!;
}