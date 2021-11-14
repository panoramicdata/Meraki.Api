namespace Meraki.Api.Sections.Products.Sm;

public class SmDevicesSection
{
	public ISmDevices Devices { get; internal set; } = null!;
	public ISmDevicesBypassActivationLockAttempts BypassActivationLockAttempts { get; internal set; } = null!;
}