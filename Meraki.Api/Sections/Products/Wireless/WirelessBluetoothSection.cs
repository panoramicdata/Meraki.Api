namespace Meraki.Api.Sections.Products.Wireless;

/// <summary>
/// Provides access to wireless bluetooth API endpoints
/// </summary>
public class WirelessBluetoothSection
{
	/// <summary>
	/// Return the bluetooth settings for a wireless device
	/// </summary>

	public IWirelessBluetoothSettings Settings { get; internal set; } = null!;
}
