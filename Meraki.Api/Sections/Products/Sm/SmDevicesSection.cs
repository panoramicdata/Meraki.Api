namespace Meraki.Api.Sections.Products.Sm;

public class SmDevicesSection
{
	public ISmDevices Devices { get; internal set; } = null!;
	public ISmDevicesBypassActivationLockAttempts BypassActivationLockAttempts { get; internal set; } = null!;
	public ISmDevicesCellularUsageHistory CellularUsageHistory { get; internal set; } = null!;
	public ISmDevicesCerts Certs { get; internal set; } = null!;
	public ISmDevicesConnectivity Connectivity { get; internal set; } = null!;
	public ISmDevicesDesktopLogs DesktopLogs { get; internal set; } = null!;
	public ISmDevicesDeviceCommandLogs DeviceCommandLogs { get; internal set; } = null!;
	public ISmDevicesDeviceProfiles DeviceProfiles { get; internal set; } = null!;
}