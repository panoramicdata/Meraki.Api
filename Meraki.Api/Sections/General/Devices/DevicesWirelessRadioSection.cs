namespace Meraki.Api.Sections.General.Devices;
/// <summary>
/// Provides access to devices wireless radio API endpoints
/// </summary>
public class DevicesWirelessRadioSection
{
	/// <summary>
	/// Get the AFC position of a device
	/// </summary>

	public IDevicesWirelessRadioAfc Afc { get; internal set; } = null!;
}
